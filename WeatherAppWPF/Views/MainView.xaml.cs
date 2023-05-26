using System.Windows;

namespace WeatherAppWPF.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new ViewModels.MainViewModel();
        }
    }
}
