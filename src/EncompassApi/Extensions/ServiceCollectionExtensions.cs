using EncompassApi.Clients;
using EncompassApi.Configuration;
using EncompassApi.MessageHandlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace EncompassApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEncompassTokenHandlerWithRetry(this IServiceCollection services, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = encompassTokenClientOptions.ClientId,
                ApiClientSecret = encompassTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            services.AddSingleton(clientParameters);

            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds);

            services.AddSingleton(options);
            services.AddHttpClient(encompassTokenClientOptions.ClientName, c => {
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(
                            $"{WebUtility.UrlEncode(encompassTokenClientOptions.ClientId)}:{WebUtility.UrlEncode(encompassTokenClientOptions.ClientSecret)}")));
            })
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            services.AddScoped<ITokenClient>(sp =>
                new EncompassTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(encompassTokenClientOptions.ClientName), options));

            services.AddEncompassClient(encompassTokenClientOptions)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()))
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));

            return services;
        }

        public static IServiceCollection AddFairwayTokenHandlerWithRetry(this IServiceCollection services, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = fairwayTokenClientOptions.ClientId,
                ApiClientSecret = fairwayTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            services.AddSingleton(clientParameters);

            IOptions<FairwayTokenClientOptions> tokenClientIOptions = Options.Create(fairwayTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(fairwayTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(fairwayTokenClientOptions.TimeoutInSeconds);

            services.AddSingleton(tokenClientIOptions);
            services.AddHttpClient(fairwayTokenClientOptions.ClientName)
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            services.AddScoped<ITokenClient>(sp =>
                new FairwayTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(fairwayTokenClientOptions.ClientName), tokenClientIOptions));

            services.AddEncompassClient(fairwayTokenClientOptions)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()))
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));

            return services;
        }

        private static IHttpClientBuilder AddEncompassClient(this IServiceCollection services, BaseHttpClientOptions options)
        {
            var builder = services.AddHttpClient("EncompassClient", client =>
            {
                client.BaseAddress = new Uri(options.BaseUrl);

                if (options.ContentCompression) {
                    client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));
                }
            });

            if (options.ContentCompression) {
                builder.ConfigurePrimaryHttpMessageHandler(clientHandler => new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip
                });
            } else {
                builder.ConfigurePrimaryHttpMessageHandler(clientHandler => new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.None
                });
            }

            return builder;
        }
    }
}
