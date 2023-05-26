using System;
using System.Net;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace WeatherAppGui
{
    public partial class MainScreen : Form
    {
        #region Fields
        private string city;
        private Root weather;
        #endregion

        #region Constructor
        public MainScreen(string cityName)
        {
            InitializeComponent();
            city = cityName;
        }
        #endregion

        #region Private methods
        private void Start(object sender, EventArgs e)
        {
            CityLabel.Text = city;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerAsync();
        }

        private string Getweather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=8cbf2c0cf7cd1c17ae63ac6f87f2ffe0", city);
                var json = web.DownloadString(url);
                return json;
            }
        }

        private void UpdateData()
        {
            string json = Getweather();
            weather = JsonSerializer.Deserialize<Root>(json);
        }
        #endregion

        #region Events
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            WelcomeScreen WelcomeWindow = new WelcomeScreen();
            Hide();
            WelcomeWindow.ShowDialog();
            Close();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UpdateData();
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Progress.Value = e.ProgressPercentage;
        }
        #endregion

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {            
            UpdateTime.Text = "Ostatnia aktualizacja: " + DateTime.Now;
            Temperature.Text = "Temperatura: " + (weather.main.temp - 273.15).ToString("00.00") + "°C";
            Pressure.Text = "Ciśnienie: " + weather.main.pressure + "hPa";
            Visibility.Text = "Widoczność: " + (weather.visibility / 100) + "%";
            WindSpeed.Text = "Prędkość wiatru: " + weather.wind.speed + "km/h";
            Sky.Text = "Niebo: " + weather.weather[0].description;
            if (Progress.Visible == true)
            {
                Progress.Visible = false;
            }
        }
    }
}
