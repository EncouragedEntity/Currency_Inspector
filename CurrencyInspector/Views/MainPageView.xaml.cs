using CurrencyInspector.ViewModels;
using CurrencyInspector.Models;
using System.Windows.Controls;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using System.Collections.ObjectModel;

namespace CurrencyInspector.Views
{
    /// <summary>
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : UserControl
    {
        MainPageViewModel vm;
        ObservableCollection<AssetSimplifiedModel>? assets;
        public MainPageView()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
            vm = (MainPageViewModel)DataContext;
            assetsDataGrid.ItemsSource = vm.AssetsSimple;
            assets = assetsDataGrid.ItemsSource as ObservableCollection<AssetSimplifiedModel>;
        }

        private void ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            var detailsWindow = new DetailsWindowView(vm.Assets[assetsDataGrid.SelectedIndex]);
            detailsWindow.Show();
        }

        private void textSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textSearch.Text==String.Empty)
            {
                textBlockSearch.Visibility = Visibility.Visible;
                assetsDataGrid.ItemsSource = vm.AssetsSimple;
                return;
            }
            textBlockSearch.Visibility = Visibility.Hidden;
            if (assets!.Any(asset => asset.Name == textSearch.Text))
            {
                FilterDataGrid();
                return;
            }
            assetsDataGrid.ItemsSource = vm.AssetsSimple;
        }

        private void textSearch_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                FilterDataGrid();
            }
        }

        private void FilterDataGrid()
        {
            var result = assets!.Where(asset => asset.Name == textSearch.Text).ToList();
            if (result is not null && result.Count != 0)
                assetsDataGrid.ItemsSource = result;
            assetsDataGrid.Items.Refresh();
        }
    }
}
