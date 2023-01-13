using System.Windows;
using System.Windows.Input;


namespace CurrencyInspector.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        private bool IsMaximized { get; set; } = false;
        private bool IsControlShown { get; set; } = true;
        public ShellView()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = false;
                    return;
                }
                this.WindowState = WindowState.Maximized;
                IsMaximized = true;
            }
        }
    }
}
