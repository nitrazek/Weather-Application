using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WeatherAppWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ContentControl content;
        public ContentControl Content
        {
            get => content;
            set
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public MainViewModel()
        {
            Content = new Views.WelcomeView(this);
        }

        public void SwitchView(string city)
        {
            Content = new Views.DetailsView(city, this);
        }

        public void SwitchView()
        {
            Content = new Views.WelcomeView(this);
        }
    }
}
