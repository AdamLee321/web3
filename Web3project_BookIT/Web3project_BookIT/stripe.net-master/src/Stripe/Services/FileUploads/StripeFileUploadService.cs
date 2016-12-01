﻿using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeFileUploadService : StripeService
    {
        public StripeFileUploadService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeFileUpload Create(string fileName, Stream fileStream, string purpose, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                Requestor.PostFile(Urls.FileUploads, fileName, fileStream, purpose, SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeFileUpload Get(string fileUploadId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.FileUploads}/{fileUploadId}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual IEnumerable<StripeFileUpload> List(StripeFileUploadListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeFileUpload>.MapCollectionFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.FileUploads, true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }



        //Async
        public virtual async Task<StripeFileUpload> CreateAsync(string fileName, Stream fileStream, string purpose, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                await Requestor.PostFileAsync(Urls.FileUploads, fileName, fileStream, purpose, SetupRequestOptions(requestOptions), cancellationToken)
            );
        }

        public virtual async Task<StripeFileUpload> GetAsync(string fileUploadId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileUpload>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.FileUploads}/{fileUploadId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public virtual async Task<IEnumerable<StripeFileUpload>> ListAsync(StripeFileUploadListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeFileUpload>.MapCollectionFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, Urls.FileUploads, true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }
    }
}
