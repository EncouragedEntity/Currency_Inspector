using Caliburn.Micro;
namespace CurrencyInspector.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public void LoadMainPage()
        {
            ActivateItemAsync(new MainPageViewModel());
        }

        public void LoadCurrencyDetailsPage()
        {
            ActivateItemAsync(new CurrencyDetailsPageViewModel());
        }
    }
}
