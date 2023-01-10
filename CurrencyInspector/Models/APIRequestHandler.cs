using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CurrencyInspector.Models
{
    class APIRequestHandler
    {
        #region Assets
        public List<AssetModel> GetAllAssets()
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

            return JsonConvert.DeserializeObject<List<AssetModel>>(JsonString)!;
        }
        public List<AssetModel> GetAssets(int Size = 10, int Start = 1)
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

            return JsonConvert.DeserializeObject<List<AssetModel>>(JsonString)!;
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
    }
}
