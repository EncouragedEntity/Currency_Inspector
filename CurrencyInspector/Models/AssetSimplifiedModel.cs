using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyInspector.Models
{
    public class AssetSimplifiedModel
    {
        [JsonProperty(PropertyName = "asset_id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public double Price { get; set; }

        public AssetSimplifiedModel(string id, string name, double price) 
        {
            ID=id;
            Name=name;
            Price=price;
        }
        public AssetSimplifiedModel():this(String.Empty, String.Empty, 0) { }
    }
}
