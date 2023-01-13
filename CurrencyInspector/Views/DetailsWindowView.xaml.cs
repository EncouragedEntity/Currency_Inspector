using Caliburn.Micro;
using CurrencyInspector.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace CurrencyInspector.Views
{
    /// <summary>
    /// Interaction logic for DetailsWindowView.xaml
    /// </summary>
    public partial class DetailsWindowView : Window
    {
        private AssetModel _asset;
        public AssetModel Asset
        {
            get
            {
                return _asset;
            }
            set
            {
                _asset = value;
            }
        }

        private ObservableCollection<MarketModel> _markets;
        public ObservableCollection<MarketModel> Markets
        {
            get => _markets;
            set
            {
                _markets = value;
            }
        }

        public DetailsWindowView(AssetModel asset)
        {
            Asset = asset;
            SetMarkets();
            InitializeComponent();
            myGrid.DataContext = Asset;
            PropertiesGrid.DataContext = this;
        }

        private void SetMarkets()
        {
            Markets = Asset.GetMarkets();
            if (Markets is null || Markets.Count == 0)
                MarketsControl.ItemsSource = new List<MarketModel> { new MarketModel() };
        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
        private void Window_Deactivated(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (InvalidOperationException) { }
        }
    }
}
