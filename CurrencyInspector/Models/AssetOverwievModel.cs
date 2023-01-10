using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyInspector.Models
{
    public class AssetOverwievModel
    {
        [JsonProperty(PropertyName = "asset_id")]
        public string AssetId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
