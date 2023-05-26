using System.Windows.Input;
using WeatherAppWPF.Views;
using WeatherAppWPF.Command;
using System.Windows;
using System.Threading;

namespace WeatherAppWPF.ViewModels
{
    class WelcomeViewModel : BaseViewModel
    {
        #region Fields
        private readonly MainViewModel mainVM;
        private bool error = false;
        public string cityName = "";
        #endregion

        #region Properties
        public string CityName { get; set; } = "";
        public bool Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;
                OnPropertyChanged("Error");
            }
        }
        public ICommand Search { get; set; }
        public ICommand Enter { get; set; }
        #endregion

        #region Constructor
        public WelcomeViewModel(MainViewModel mainVM)
        {
            this.mainVM = mainVM;
            Search = new RelayCommand(Initialize);
            Enter = new RelayCommand(Initialize);
        }
        #endregion

        #region AllMethods
        private void Initialize()
        {
            if (CityName.Length > 0)
            {
                if (Error == true) Error = false;
                cityName = CityName;
                //MessageBox.Show(CityName);
                /*MainView page = new MainView(cityName, window);
                window.Content = page;*/
                mainVM.SwitchView(cityName);
            }
            else
            {
                Error = true;
            }
        }
        #endregion
    }
}
