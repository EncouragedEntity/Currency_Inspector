using Newtonsoft.Json;
using System;

namespace CurrencyInspector.Models
{
    public class MarketModel
    {
        [JsonProperty(PropertyName = "exchange_id")]
        public string ExchangeId { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "base_asset")]
        public string BaseAsset { get; set; }

        [JsonProperty(PropertyName = "quote_asset")]
        public string QuoteAsset { get; set; }

        [JsonProperty(PropertyName = "price_unconverted")]
        public double PriceUnconverted { get; set; }

        [JsonProperty(PropertyName = "price")]
        public double Price { get; set; }

        [JsonProperty(PropertyName = "change_24h")]
        public double Change_24h { get; set; }

        [JsonProperty(PropertyName = "spread")]
        public double Spread { get; set; }

        [JsonProperty(PropertyName = "volume_24h")]
        public double Volume_24h { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
