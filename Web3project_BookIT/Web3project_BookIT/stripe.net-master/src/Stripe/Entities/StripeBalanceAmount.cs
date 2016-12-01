﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBalanceAmount : StripeEntity
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
 }