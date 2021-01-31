﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.EFolder
{
    /// <summary>
    /// ExportAttachmentsJob
    /// </summary>
    public sealed class ExportAttachmentsJob : ExtensibleObject
    {
        /// <summary>
        /// Unique identifier of the export job.
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Status of the export job.
        /// </summary>
        public StringEnumValue<ExportStatus> Status { get; set; }

        /// <summary>
        /// Object containing details of the job export error in case the status of the job is Failed.
        /// </summary>
        public ErrorObject? Error { get; set; }

        /// <summary>
        /// Object containing information about the file generated by the export job.
        /// </summary>
        public FileResponse File { get; set; }

        /// <summary>
        /// The <see cref="IEncompassRestClient"/> associated with this object.
        /// </summary>
        [JsonIgnore]
        public IEncompassRestClient? Client { get; private set; }

        /// <summary>
        /// ExportAttachmentsJob constructor.
        /// </summary>
        /// <param name="jobId">Unique identifier of the export job.</param>
        /// <param name="file">Object containing information about the file generated by the export job.</param>
        public ExportAttachmentsJob(string jobId, FileResponse file)
        {
            Preconditions.NotNullOrEmpty(jobId, nameof(jobId));
            Preconditions.NotNull(file, nameof(file));

            JobId = jobId;
            File = file;
        }

        /// <summary>
        /// Initializes the export job object with the specified <paramref name="client"/>. This allows the use of the Refresh and Download methods.
        /// </summary>
        /// <param name="client"></param>
        public void Initialize(IEncompassRestClient client)
        {
            Preconditions.NotNull(client, nameof(client));

            Client = client;
        }

        /// <summary>
        /// Refreshes the export job's status.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task RefreshAsync(CancellationToken cancellationToken = default) => GetClient().EFolder.RefreshExportJobAsync(this, cancellationToken);

        /// <summary>
        /// Downloads the attachments for the specified export job as a pdf file byte array.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<byte[]> DownloadAsync(CancellationToken cancellationToken = default) => GetClient().EFolder.DownloadAttachmentsAsync(this, cancellationToken);

        /// <summary>
        /// Downloads the attachments for the specified export job as a pdf file stream.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<Stream> DownloadStreamAsync(CancellationToken cancellationToken = default) => GetClient().EFolder.DownloadAttachmentsStreamAsync(this, cancellationToken);

        private IEncompassRestClient GetClient() => Client ?? throw new InvalidOperationException("ExportAttachmentsJob object must be initialized to refresh or download the attachment contents");
    }
}
