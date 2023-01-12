using Caliburn.Micro;
using CurrencyInspector.Models;
using System.Collections.ObjectModel;

namespace CurrencyInspector.ViewModels
{
    public class CurrencyDetailsPageViewModel: Screen
    {
        public CurrencyDetailsPageViewModel(AssetSimplifiedModel? assetSimplified, ObservableCollection<AssetModel>? assets)
        {
            
        }

        public CurrencyDetailsPageViewModel() : this(null, null) { }
    }
}
