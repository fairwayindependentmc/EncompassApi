using EncompassApi.xUnitTests.Extensions;
using EncompassApi.xUnitTests.TestServices;
using FluentAssertions;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace EncompassApi.xUnitTests.Loans
{
    public class LoanAttachments
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;

        public LoanAttachments(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### DocumentsTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;
        }

        [Fact]
        public async Task GetLoanAttachmentsTestAsync()
        {
            var seed = Payloads.Helper.GetLoanDocuments();
            var targets = seed.Should()
                .BeSerializable<JObject, EncompassApi.Loans.Attachments.LoanAttachment>(seed);
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
                .GetAttachmentsApi(mockedLoanId).GetAttachmentsAsync();
        }

        [Fact]
        public async Task UploadAttachmentAsyncTestAsync()
        {
            _outputWriter.WriteLine("### UploadAttachmentAsyncTestAsync initiating! ###");

            var mediaUrl = Payloads.Helper.GetMediaUrlObject();
            var mediaUrlObject = mediaUrl.Should<EncompassApi.Loans.Attachments.MediaUrlObject>().BeSerializable<EncompassApi.Loans.Attachments.MediaUrlObject>(mediaUrl);
            var seed = Payloads.Helper.GetLoanAttachments();
            var targets = seed.Should()
                .BeSerializable<JObject, EncompassApi.Loans.Attachments.LoanAttachment>(seed)
                .ChangeProperty(nameof(EncompassApi.Loans.Attachments.LoanAttachment.IsActive), true);

            var target = targets.FirstOrDefault();
            target.Should().NotBeNull(because: "Target is null!");
            var attachmentTitle = target.Title;
            var expectedAttacments = targets.Where(_ => _.Title.Equals(attachmentTitle));
            var mockedLoanId = Guid.NewGuid().ToString();
            var attachmentObject = _mockedEncompassClient
                .SetupResponseMessage(resp =>
                {
                    resp.StatusCode = System.Net.HttpStatusCode.OK;
                    resp.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(mediaUrlObject));
                    resp.Headers.Location = new Uri("https://www.example.com/" + "xxx.pdf");
                }, testHeader: new KeyValuePair<string, string>("TestHeader", Faker.Lorem.GetFirstWord()))
                .GetAttachmentsApi(mockedLoanId);

            attachmentObject.ApiResponseEventHandler += (object sender, ApiResponseEventArgs e) =>
            {
                var resp = e.Response;
            };

            // Mock stream
            var mockStream = new Mock<Stream>();
            bool wasCalled;
            mockStream.Setup(s => s.CanWrite).Returns(true);
            mockStream.Setup(s => s.Write(It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>())).Callback((byte[] bytes, int offs, int c) =>
                {
                    wasCalled = true;
                });

            await attachmentObject.UploadAttachmentAsync(target, mockStream.Object);
        }
    }
}
