using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTokenCreateOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("bank_account")]
        public BankAccountOptions BankAccount { get; set; }
        public object CardAddressCountry { get; set; }
        public object CardAddressLine2 { get; set; }
        public object CardAddressCity { get; set; }
    }
}