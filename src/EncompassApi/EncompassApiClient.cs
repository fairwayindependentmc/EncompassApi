﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Calculators;
using EncompassApi.Clients;
using EncompassApi.Company;
using EncompassApi.Configuration;
using EncompassApi.Contacts;
using EncompassApi.EFolder;
using EncompassApi.LoanBatch;
using EncompassApi.LoanFolders;
using EncompassApi.LoanPipeline;
using EncompassApi.Loans;
using EncompassApi.MessageHandlers;
using EncompassApi.Organizations;
using EncompassApi.Schema;
using EncompassApi.Services;
using EncompassApi.Settings;
using EncompassApi.Token;
using EncompassApi.Utilities;
using EncompassApi.Webhook;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Extensions.Http;

namespace EncompassApi
{
    /// <summary>
    /// The client object to make calls to the Encompass Apis. Use the static factory Create* methods to create a client object.
    /// </summary>
    public interface IEncompassApiClient : IDisposable
#if IASYNC_DISPOSABLE
        , IAsyncDisposable
#endif
    {
        /// <summary>
        /// The http client
        /// </summary>
        HttpClient HttpClient { get; }
        /// <summary>
        /// A base Api client for use when Apis aren't supported directly.
        /// </summary>
        IBaseApiClient BaseApiClient { get; }
        /// <summary>
        /// The Loan Batch Update Apis.
        /// </summary>
        IBatchUpdate BatchUpdate { get; }
        /// <summary>
        /// The Calculators Apis.
        /// </summary>
        ICalculators Calculators { get; }
        /// <summary>
        /// The Company Apis.
        /// </summary>
        ICompany Company { get; }
        /// <summary>
        /// The Contacts Apis.
        /// </summary>
        IContacts Contacts { get; }
        /// <summary>
        /// The EFolder Apis.
        /// </summary>
        IEFolder EFolder { get; }
        /// <summary>
        /// The Loan Folders Apis.
        /// </summary>
        ILoanFolders LoanFolders { get; }
        /// <summary>
        /// The Loans Apis.
        /// </summary>
        ILoans Loans { get; }
        /// <summary>
        /// The Organizations Apis.
        /// </summary>
        IOrganizations Organizations { get; }
        /// <summary>
        /// The Loan Pipeline Apis.
        /// </summary>
        IPipeline Pipeline { get; }
        /// <summary>
        /// The Schema Apis.
        /// </summary>
        ISchema Schema { get; }
        /// <summary>
        /// The Services Apis.
        /// </summary>
        IServices Services { get; }
        /// <summary>
        /// The Settings Apis.
        /// </summary>
        ISettings Settings { get; }

        /// <summary>
        /// Specifies how the client should handle undefined custom fields.
        /// </summary>
        UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }
        /// <summary>
        /// The Webhook Apis.
        /// </summary>
        IWebhook Webhook { get; }
        /// <summary>
        /// Expose Resource Locks from Interface
        /// </summary>
        ResourceLocks.ResourceLocks ResourceLocks { get; }
        /// <summary>
        /// Property for sharing common cache between multiple clients such as custom field descriptors.
        /// </summary>
        CommonCache CommonCache { get; }

        /// <summary>
        /// Set by ClientParameters.BaseAddress. The URL to call for API calls. Defaults to "https://api.elliemae.com/".
        /// </summary>
        string BaseAddress { get; set; }

        /// <summary>
        /// An event that occurs when an Api response is received.
        /// </summary>
        event EventHandler<IApiResponseEventArgs> ApiResponse;
        void InvokeApiResponse(HttpResponseMessage response);
    }

    /// <summary>
    /// The client object to make calls to the Encompass Apis. Use the static factory Create* methods to create a client object.
    /// </summary>
    public sealed class EncompassApiClient : IEncompassApiClient
    {
        private readonly IEncompassApiClient _encompassApiSerice;
#if NET45
        static EncompassApiClient()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
        }
#endif

        /// <summary>
        /// Creates a client object which will automatically invoke the tokenInitializer when making an Api call with an expired token.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="tokenInitializer">The function to retrieve a new token when making an Api call with an expired token.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassApiClient> CreateAsync(IClientParameters parameters, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            Preconditions.NotNull(parameters, nameof(parameters));

            //TODO HttpClient Private Method setup
            var client = new EncompassApiClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
            return client;
        }

        /// <summary>
        /// Creates a client object from user credentials. It does not automatically retrieve a new token when the current one expires so most of the time you'll probably want to use the CreateAsync method instead.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="instanceId">The encompass instance id.</param>
        /// <param name="userId">The encompass user id.</param>
        /// <param name="password">The encompass user password.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassApiClient> CreateFromUserCredentialsAsync(IClientParameters parameters, string instanceId, string userId, string password, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            var encompassTokenClientOptions = new EncompassTokenClientOptions
            {
                BaseUrl = parameters.BaseAddress,
                ClientId = parameters.ApiClientId,
                ClientSecret = parameters.ApiClientSecret,
                EncompassInstanceId = instanceId,
                ClientName = "EncompassTokenClient",
                Password = password,
                Username = userId,
                Retry = true,
                RetryCount = 3,
                TimeoutInSeconds = 30
            };

            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(parameters.TimeoutRetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(parameters.Timeout);

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton(options);

            serviceCollection.AddHttpClient(encompassTokenClientOptions.ClientName)
                .AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(parameters.TimeoutRetryCount))
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(parameters.Timeout));

            serviceCollection.AddScoped<ITokenClient>(sp => new EncompassTokenClient(sp.GetService<IHttpClientFactory>().CreateClient("EncompassTokenClient"), options));

            serviceCollection.AddHttpClient("EncompassClient")
                .AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(parameters.TimeoutRetryCount))
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(parameters.Timeout))
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()));

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var client = new EncompassApiClient(parameters, new EncompassApiService(httpClientFactory.CreateClient("EncompassHttpClient"), parameters));

            return client;
        }

        /// <summary>
        /// Creates a client object from an authorization code.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="redirectUri">The redirect uri associated with the authorization code.</param>
        /// <param name="authorizationCode">The authorization code to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassApiClient> CreateFromAuthorizationCodeAsync(IClientParameters parameters, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            //TODO HttpClient Private Method setup
            var client = new EncompassApiClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
            return client;
        }

        /// <summary>
        /// Creates a client object from an existing access token.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="accessToken">The access token to use.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task<EncompassApiClient> CreateFromAccessTokenAsync(IClientParameters parameters, string accessToken, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            //TODO HttpClient Private Method setup
            var client = new EncompassApiClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
            return client;
        }

        /// <summary>
        /// This method is for partner API integration only. You probably want <see cref="CreateFromUserCredentialsAsync(ClientParameters, string, string, string, CancellationToken)"/> instead.
        /// </summary>
        /// <param name="parameters">The parameters to initialize the client object with.</param>
        /// <param name="instanceId">The encompass instance id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        [Obsolete("This method is for partner API integration only. You probably want CreateFromUserCredentialsAsync instead.")]
        public static async Task<EncompassApiClient> CreateFromClientCredentialsAsync(IClientParameters parameters, string instanceId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));

            //TODO HttpClient Private Method setup
            var client = new EncompassApiClient(parameters, new EncompassApiService(new HttpClient(), parameters));
            //removed token initialization
            return client;
        }

        private EFolder.EFolder? _eFolder;

        #region Properties
        /// <inheritdoc/>
        public UndefinedCustomFieldHandling UndefinedCustomFieldHandling { get; set; }

        /// <summary>
        /// The Loans Apis.
        /// </summary>
        public Loans.Loans Loans => (Loans.Loans)_encompassApiSerice.Loans;
        ILoans IEncompassApiClient.Loans => Loans;

        /// <summary>
        /// The Schema Apis.
        /// </summary>
        public Schema.Schema Schema => (Schema.Schema)_encompassApiSerice.Schema;
        ISchema IEncompassApiClient.Schema => Schema;

        /// <summary>
        /// The Webhook Apis.
        /// </summary>
        public Webhook.Webhook Webhook => (Webhook.Webhook)_encompassApiSerice.Webhook;
        IWebhook IEncompassApiClient.Webhook => Webhook;

        /// <summary>
        /// The Loan Pipeline Apis.
        /// </summary>
        public Pipeline Pipeline => (Pipeline)_encompassApiSerice.Pipeline;
        IPipeline IEncompassApiClient.Pipeline => Pipeline;

        /// <summary>
        /// The Loan Batch Update Apis.
        /// </summary>
        public BatchUpdate BatchUpdate => (BatchUpdate)_encompassApiSerice.BatchUpdate;
        IBatchUpdate IEncompassApiClient.BatchUpdate => BatchUpdate;

        /// <summary>
        /// The Contacts Apis.
        /// </summary>
        public Contacts.Contacts Contacts => (Contacts.Contacts)_encompassApiSerice.Contacts;
        IContacts IEncompassApiClient.Contacts => Contacts;

        public ResourceLocks.ResourceLocks ResourceLocks => _encompassApiSerice.ResourceLocks;


        /// <summary>
        /// The Loan Folders Apis.
        /// </summary>
        public LoanFolders.LoanFolders LoanFolders => (LoanFolders.LoanFolders)_encompassApiSerice.LoanFolders;
        ILoanFolders IEncompassApiClient.LoanFolders => LoanFolders;

        /// <summary>
        /// The Settings Apis.
        /// </summary>
        public Settings.Settings Settings => (Settings.Settings)_encompassApiSerice.Settings;
        ISettings IEncompassApiClient.Settings => Settings;

        /// <summary>
        /// The Services Apis.
        /// </summary>
        public Services.Services Services => (Services.Services)_encompassApiSerice.Services;
        IServices IEncompassApiClient.Services => Services;

        /// <summary>
        /// The Company Apis.
        /// </summary>
        public Company.Company Company => (Company.Company)_encompassApiSerice.Company;
        ICompany IEncompassApiClient.Company => Company;

        /// <summary>
        /// The Organizations Apis.
        /// </summary>
        public Organizations.Organizations Organizations => (Organizations.Organizations)_encompassApiSerice.Organizations;
        IOrganizations IEncompassApiClient.Organizations => Organizations;

        /// <summary>
        /// The Calculators Apis.
        /// </summary>
        public Calculators.Calculators Calculators => (Calculators.Calculators)_encompassApiSerice.Calculators;
        ICalculators IEncompassApiClient.Calculators => Calculators;

        /// <summary>
        /// The EFolder Apis.
        /// </summary>
        public EFolder.EFolder EFolder => (EFolder.EFolder)_encompassApiSerice.EFolder;
        IEFolder IEncompassApiClient.EFolder => EFolder;

        /// <inheritdoc/>
        public CommonCache CommonCache { get; }

        public HttpClient HttpClient => _encompassApiSerice.HttpClient;


        /// <summary>
        /// A base Api client for use when Apis aren't supported directly.
        /// </summary>
        public BaseApiClient BaseApiClient => (BaseApiClient)_encompassApiSerice.BaseApiClient;
        IBaseApiClient IEncompassApiClient.BaseApiClient => BaseApiClient;
        #endregion
        /// <inheritdoc/>
        public string BaseAddress 
        { 
            get 
            {
                return _encompassApiSerice.BaseAddress;
            }
            set 
            {
                _encompassApiSerice.BaseAddress = value;
            }
        }


        //TODO: This needs to be separated in the interface.
        //ISP for managing events. Need to be removed from base interface class

        /// <summary>
        /// An event that occurs when an Api response is received.
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? ApiResponse;

        private EventHandler<IApiResponseEventArgs>? _interfaceApiResponse;

        event EventHandler<IApiResponseEventArgs>? IEncompassApiClient.ApiResponse
        {
            add
            {
                var result = _interfaceApiResponse += value;
                if (result != null)
                {
                    ApiResponse += InterfaceApiResponse;
                }
            }
            remove
            {
                var result = _interfaceApiResponse -= value;
                if (result == null)
                {
                    ApiResponse -= InterfaceApiResponse;
                }
            }
        }

        private void InterfaceApiResponse(object sender, ApiResponseEventArgs e)
        {
            _interfaceApiResponse?.Invoke(sender, e);
        }

        public void InvokeApiResponse(HttpResponseMessage response) => _encompassApiSerice.InvokeApiResponse(response);
        

        internal EncompassApiClient(IClientParameters parameters)
        {
            ApiResponse = parameters.ApiResponse;
            CommonCache = (parameters.CommonCache ??= new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
        }

        internal EncompassApiClient(IClientParameters parameters, IEncompassApiClient encompassApiService)
        {
            _encompassApiSerice = encompassApiService;
            ApiResponse = parameters.ApiResponse;
            CommonCache = (parameters.CommonCache ??= new CommonCache());
            UndefinedCustomFieldHandling = parameters.UndefinedCustomFieldHandling;
        }

        /// <summary>
        /// Disposes of the client object.
        /// </summary>
        public void Dispose()
        {
            _encompassApiSerice.Dispose();
        }

#if IASYNC_DISPOSABLE
        /// <summary>
        /// Revokes the current access token and disposes of the client object asynchronously.
        /// </summary>
        /// <returns></returns>
        public async ValueTask DisposeAsync()
        {
            _encompassApiSerice.Dispose();
            Dispose();
        }
#endif
    }
}