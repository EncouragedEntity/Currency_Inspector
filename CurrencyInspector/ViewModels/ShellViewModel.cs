using Caliburn.Micro;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace CurrencyInspector.ViewModels
{
    public class ShellViewModel : Conductor<Screen>
    {
        public ShellViewModel()
        {
            LoadMainPage();
        }

        public void LoadMainPage() => Task.Run(() => ActivateItemAsync(new MainPageViewModel()));

        public void LoadCurrencyDetailsPage() => Task.Run(() => ActivateItemAsync(new CurrencyDetailsPageViewModel()));

        public void LogOut() => Application.Current.Shutdown();
    }
}
