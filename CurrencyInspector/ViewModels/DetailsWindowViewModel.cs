using CurrencyInspector.Models;
using System.Collections.ObjectModel;

namespace CurrencyInspector.ViewModels
{
    public class DetailsWindowViewModel
    {
        private ObservableCollection<MarketModel> _assetMarkets;
        public ObservableCollection<MarketModel> AssetMarkets
        {
            get
            { return _assetMarkets; }
            set
            { _assetMarkets = value; }
        }

        public DetailsWindowViewModel(string id)
        {
            AssetMarkets = new APIRequestHandler().GetAssetMarkets(id).markets;
        }
    }
}
