using Caliburn.Micro;
using CurrencyInspector.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace CurrencyInspector.ViewModels
{
    public class MainPageViewModel: Screen, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AssetModel> _assets = null;
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
                    if(this.PropertyChanged != null)
                        PropertyChanged(this,new PropertyChangedEventArgs("Assets"));
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

        public MainPageViewModel()
        {
            Assets = new ObservableCollection<AssetModel>();
            SetAssets();
        }

        public void SetAssets()
        {
            APIRequestHandler API = new APIRequestHandler();
            Assets = new ObservableCollection<AssetModel>(API.GetAssets().assets);
        }
    }
}
