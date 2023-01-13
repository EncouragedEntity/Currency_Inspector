using Caliburn.Micro;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;

namespace CurrencyInspector.Models
{
    public class AssetModel
    {
        [JsonProperty(PropertyName = "asset_id")]
        public string AssetId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public double Price { get; set; }

        [JsonProperty(PropertyName = "volume_24h")]
        public double Volume_24h { get; set; }

        [JsonProperty(PropertyName = "change_1h")]
        public double Change_1h { get; set; }

        [JsonProperty(PropertyName = "change_24h")]
        public double Change_24h { get; set; }

        [JsonProperty(PropertyName = "change_7d")]
        public double Change_7d { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        public AssetSimplifiedModel Simplify() => new AssetSimplifiedModel(AssetId, Name, Price);

        public ObservableCollection<MarketModel> GetMarkets() => new APIRequestHandler().GetAssetMarkets(AssetId).markets;
    }
}
