using Caliburn.Micro;
using CurrencyInspector.Models;
using CurrencyInspector.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace CurrencyInspector.ViewModels
{
    public class MainPageViewModel: Conductor<Screen>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<AssetModel>? _assets = null;
        public ObservableCollection<AssetModel> Assets 
        {
            get
            {
                return _assets;
            }
            set 
            {
                if (_assets != value)
                {
                    _assets = value;
                    if(PropertyChanged != null)
                        PropertyChanged(this,new PropertyChangedEventArgs("Assets"));
                }
            } 
        }

        private ObservableCollection<AssetSimplifiedModel>? _assetsSimple = null;
        public ObservableCollection<AssetSimplifiedModel> AssetsSimple
        {
            get
            {
                return _assetsSimple;
            }
            set
            {
                if (_assetsSimple != value)
                {
                    _assetsSimple = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("AssetsSimple"));
                }
            }
        }

        private int _amountOfAssets = 10;
        public int AmountOfAssets 
        {
            get
            {
                return _amountOfAssets;
            }
            set
            {
                _amountOfAssets = value;
                NotifyOfPropertyChange(()=>AmountOfAssets);
            }
        }

        private AssetSimplifiedModel _selectedAsset;
        public AssetSimplifiedModel SelectedAsset
        {
            get
            {
                return _selectedAsset;
            }
            set
            {
                if (_selectedAsset != value)
                {
                    _selectedAsset = value;
                    NotifyOfPropertyChange(()=>SelectedAsset);
                }
            }
        }


        public MainPageViewModel()
        {
            Assets = new ObservableCollection<AssetModel>();
            AssetsSimple = new ObservableCollection<AssetSimplifiedModel>();
            SetAssets();
            SimplifyAllAssets();
        }

        private void SimplifyAllAssets()
        {
            foreach (var asset in Assets)
            {
                AssetsSimple.Add(asset.Simplify());
            }
        }

        public void SetAssets()
        {
            APIRequestHandler API = new APIRequestHandler();
            Assets = new ObservableCollection<AssetModel>(API.GetAssets().assets);

            foreach(var item in Assets)
            {
                if (String.IsNullOrEmpty(item.Name))
                {
                    item.Name = "Empty";
                }
            }
        }
    }
}
