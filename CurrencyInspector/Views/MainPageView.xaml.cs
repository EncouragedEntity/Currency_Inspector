using CurrencyInspector.ViewModels;
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
        }
    }
}
