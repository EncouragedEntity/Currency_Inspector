using CurrencyInspector.Models;
using CurrencyInspector.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CurrencyInspector.Views
{
    /// <summary>
    /// Interaction logic for DetailsWindowView.xaml
    /// </summary>
    public partial class DetailsWindowView : Window
    {
        public DetailsWindowView(AssetModel asset)
        {
            Asset = asset;
            InitializeComponent();
            myGrid.DataContext = Asset;
        }

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
