using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using WeatherAppWPF.Command;
using WeatherAppWPF.Models;

namespace WeatherAppWPF.ViewModels
{
    class DetalisViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<CurrentDay> days = new ObservableCollection<CurrentDay>();
        private CurrentDay currentWeather;
        private MainViewModel mainVM;
        private Random random = new Random();

        private string time = "";
        private string cityName = "";
        private int progress;
        private bool progressVisibility = false;
        #endregion

        #region Properties
        /*public List<CurrentDay> Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
                OnPropertyChanged("Days");
            }
        }*/
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }
        public string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                cityName = value;
                OnPropertyChanged("CityName");
            }
        }
        public CurrentDay CurrentWeather
        {
            get
            {
                return currentWeather;
            }
            set
            {
                currentWeather = value;
                OnPropertyChanged("CurrentWeather");
            }
        }
        public int Progress
        {
            get
            {
                return progress;
            }
            set
            {
                progress = value;
                OnPropertyChanged("Progress");
            }
        }
        public bool ProgressVisibility
        {
            get
            {
                return progressVisibility;
            }
            set
            {
                progressVisibility = value;
                OnPropertyChanged("ProgressVisibility");
            }
        }
        public ICommand Return { get; set; }
        public ICommand Refresh { get; set; }
        public ICommand Exit { get; set; }

        #endregion

        #region Constructor
        public DetalisViewModel(string city, MainViewModel mainVM)
        {
            cityName = city;
            this.mainVM = mainVM;
            Return = new RelayCommand(ReturnToPreviousScreen);
            Refresh = new RelayCommand(RefreshData);
            Exit = new RelayCommand(CloseAplication);
            Start();
        }
        #endregion

        #region Private methods
        private void Start()
        {
            Console.Write("cos");
            Progress = 50;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += BackgroundWorker_DoWork;
            worker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private string Getweather()
        {
            string json = "";
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=8cbf2c0cf7cd1c17ae63ac6f87f2ffe0", cityName);
                    json = web.DownloadString(url);
                }
            }
            catch
            {
                MessageBox.Show("Nie udało się znaleźć miasta", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return json;
        }

        private void UpdateData()
        {
            try
            {
                if (ProgressVisibility == false)
                {
                    ProgressVisibility = true;
                }
                string json = Getweather();
                currentWeather = JsonSerializer.Deserialize<CurrentDay>(json);
                for (int i = 0; i < 7; i++) days.Add(JsonSerializer.Deserialize<CurrentDay>(json));
            }
            catch { }
        }

        private void GenerateData()
        {
            for (int i = 1; i < 7; i++)
            {
                int a = random.Next(1, 3);
                if (a == 1)
                {
                    days[i].main.temp = days[i].main.temp - random.Next(0, 20);
                    days[i].main.pressure = days[i].main.pressure - random.Next(0, 20);
                    days[i].visibility = random.Next(0, 100);
                    days[i].wind.speed = days[i].wind.speed - random.Next(0, 10);
                }
                else
                {
                    days[i].main.temp = days[i].main.temp + random.Next(0, 20);
                    days[i].main.pressure = days[i].main.pressure + random.Next(0, 20);
                    days[i].visibility = random.Next(0, 100);
                    days[i].wind.speed = days[i].wind.speed + random.Next(0, 10);
                }
            }
        }

        private void ShowData()
        {
            Time = DateTime.Now.ToString();
            currentWeather.main.temp -= 273.15;
            currentWeather.visibility /= 100;
            CurrentWeather = currentWeather;
            if (ProgressVisibility == true)
            {
                ProgressVisibility = false;
                Progress = 0;
            }
        } 
        #endregion

        #region Events
        private void ReturnToPreviousScreen()
        {
            mainVM.SwitchView();
        }

        private void RefreshData()
        {
            UpdateData();
            GenerateData();
            ShowData();
        }

        private void CloseAplication()
        {
            Application.Current.MainWindow.Close();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateData();
            GenerateData();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowData();
        }
        #endregion
    }
}
