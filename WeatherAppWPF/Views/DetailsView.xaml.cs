using System;
using System.Net;
using System.ComponentModel;
using System.Windows.Controls;
using System.Text.Json;
using System.Windows;
using WeatherAppWPF.ViewModels;

namespace WeatherAppWPF.Views
{
    public partial class DetailsView : UserControl
    {
        
        public DetailsView(string city, MainViewModel mainVM)
        {
            InitializeComponent();
            DataContext = new DetalisViewModel(city, mainVM);
        }
    }
}
