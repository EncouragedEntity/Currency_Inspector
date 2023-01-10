using Caliburn.Micro;
using CurrencyInspector.ViewModels;
using System.Windows;

namespace CurrencyInspector
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
