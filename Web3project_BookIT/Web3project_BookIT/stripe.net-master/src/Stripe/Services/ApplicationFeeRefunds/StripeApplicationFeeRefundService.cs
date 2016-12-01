using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeApplicationFeeRefundService : StripeBasicService<StripeApplicationFeeRefund>
    {
        public StripeApplicationFeeRefundService(string apiKey = null) : base(apiKey) { }

        // Sync
        public virtual StripeApplicationFeeRefund Create(string applicationFeeId, StripeApplicationFeeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, createOptions);
        }

        public virtual StripeApplicationFeeRefund Get(string applicationFeeId, string refundId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions);
        }

        public virtual StripeApplicationFeeRefund Update(string applicationFeeId, string refundId, StripeApplicationFeeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions, updateOptions);
        }

        public virtual IEnumerable<StripeApplicationFeeRefund> List(string applicationFeeId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, listOptions);
        }


        // Async
        public virtual Task<StripeApplicationFeeRefund> CreateAsync(string applicationFeeId, StripeApplicationFeeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, cancellationToken, createOptions);
        }

        public virtual Task<StripeApplicationFeeRefund> GetAsync(string applicationFeeId, string refundId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeApplicationFeeRefund> UpdateAsync(string applicationFeeId, string refundId, StripeApplicationFeeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions, cancellationToken, updateOptions);
        }

        public virtual Task<IEnumerable<StripeApplicationFeeRefund>> ListAsync(string applicationFeeId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, cancellationToken, listOptions);
        }
    }
}
