using EncompassApi.xUnitTests.TestServices;
using EncompassApi.Webhook;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using EncompassApi.xUnitTests.Extensions;
using System.Net.Http;

namespace EncompassApi.xUnitTests.Loans
{
    public class LoanDocumentsTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;

        public LoanDocumentsTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### DocumentsTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;

        }

        [Fact]
        public async Task GetDocumentsTestAsync()
        {
            // GetDocumentsAsync

            // _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var seed = Payloads.Helper.GetLoanDocuments();
            var targets = seed.Should()
                .BeSerializable<JObject, EncompassApi.Loans.Documents.LoanDocument>(seed);
            var target = targets.FirstOrDefault();
            var documentName = target?.Title;
            var mockedLoanId = Guid.NewGuid().ToString();
            var source = await _mockedEncompassClient
                .SetClientApiResponse((o, resp) =>
                {


                })
                .SetupResponseMessage(resp =>
                {
                    resp.StatusCode = System.Net.HttpStatusCode.OK;
                    resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(targets));
                }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .SetDocumentsApiResponseCallback(mockedLoanId, null).GetDocumentsRawAsync();

                // .MockedEncompassClient.Loans.GetLoanApis(mockedLoanId).Documents.GetDocumentsAsync();

                //.GetDocumentsApiAsync(mockedLoanId).
                //.GetDocumentsApiAsync();

                //.SetDocumentsApiResponseCallback(mockedLoanId, (a, resp) =>
                //{
                    
                //}).GetDocumentsAsync();

             

        }

        [Fact]
        public async Task CreateDocumentTestAsync()
        {
            var seed = Payloads.Helper.GetLoanDocument();
            var target = seed.Should<EncompassApi.Loans.Documents.LoanDocument>()
                .BeSerializable<EncompassApi.Loans.Documents.LoanDocument>(seed);
            target.Should().NotBeNull(because: "Target is null!");
            var documentId = target.DocumentId;
            target.DocumentId = null;
            var mockedLoanId = Guid.NewGuid().ToString();
            var source = _mockedEncompassClient
               .SetupResponseMessage(resp =>
               {
                   resp.StatusCode = System.Net.HttpStatusCode.OK;
                   resp.Content = new StringContent(documentId);
                   resp.Headers.Location = new Uri("https://www.example.com/" + "xxx.pdf");
               }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
               .GetDocumentsApi(mockedLoanId);

            source.ApiResponseEventHandler += (object sender, ApiResponseEventArgs e) => 
            {
            
            };

            var d = await source.CreateDocumentAsync(target);
        }

       
    }
}
