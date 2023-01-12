using CurrencyInspector.ViewModels;
using System.Linq;
using System.Windows.Controls;

namespace CurrencyInspector.Views
{
    /// <summary>
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : UserControl
    {
        public MainPageView()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
            var vm = (MainPageViewModel)DataContext;
            assetsDataGrid.ItemsSource = vm.AssetsSimple;
        }

        public void ShowDetails()
        {

        }
    }
}
