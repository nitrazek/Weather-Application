using System.Windows.Controls;
using WeatherAppWPF.ViewModels;

namespace WeatherAppWPF.Views
{
    public partial class WelcomeView
    {
        public WelcomeView(MainViewModel mainVM)
        {
            InitializeComponent();
            DataContext = new WelcomeViewModel(mainVM);
        }
    }
}
