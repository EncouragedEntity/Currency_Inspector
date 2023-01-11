using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CurrencyInspector.Models
{
    public class APIRequestHandler
    {
        #region Assets
        public Assets GetAllAssets()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/assets");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<Assets>(JsonString)!;
        }
        public Assets GetAssets(int Size = 10, int Start = 1)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/assets?start={Start}&size={Size}");
            WebReq.Method= "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<Assets>(JsonString)!;
        }
        public AssetModel? GetAssetByID(string ID, List<AssetModel> assets)
        {
            return assets.Find(asset => asset.AssetId == ID);
        }
        public List<AssetOverwievModel> GetAssetOverwievs()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/assetsoverview");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<AssetOverwievModel>>(JsonString)!;
        }
        #endregion
        #region Markets
        public List<MarketModel> GetAllMarkets()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/markets");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<MarketModel>>(JsonString)!;
        }
        public List<MarketModel> GetMarkets(int Size = 10, int Start = 1)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/markets?start={Start}&size={Size}");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<MarketModel>>(JsonString)!;
        }
        public List<MarketModel> GetExchangeMarkets(string ID, int Size = 10, int Start = 1)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/exchanges/{ID}/markets?start={Start}&size={Size}");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<MarketModel>>(JsonString)!;
        }
        public List<MarketModel> GetAssetMarkets(string ID, int Size = 10, int Start = 1)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/assets/{ID}/markets?start={Start}&size={Size}");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<MarketModel>>(JsonString)!;
        }
        #endregion
        #region Exchanges
        public List<ExchangeModel> GetAllExchanges()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/exchanges");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<ExchangeModel>>(JsonString)!;
        }
        public List<ExchangeModel> GetExchanges(int Size = 10, int Start = 1)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/exchanges?start={Start}&size={Size}");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<ExchangeModel>>(JsonString)!;
        }
        public ExchangeModel GetExchangeByID(string ID)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create($"https://cryptingup.com/api/exchanges/{ID}");
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string JsonString = String.Empty;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                JsonString = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<ExchangeModel>(JsonString)!;
        }
        #endregion
    }
}
