using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyInspector.Models
{
    public class ExchangeModel
    {
        [JsonProperty(PropertyName = "exchange_id")]
        public string ExchangeId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }

        [JsonProperty(PropertyName = "volume_24h")]
        public double Volume_24h { get; set; }
    }
}
