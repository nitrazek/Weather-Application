using System;
using System.Net;
using System.Timers;
using System.Text.Json;


namespace WeatherApp
{
    public class Program
    {
        public static string city;
        public static Timer aTimer;
        public static Timer bTimer;
        public static int count;
        public static int i;

        private static void OnTimedEvent(object source, ElapsedEventArgs e) { Repeat(); }
        private static void OnCountEvent(object source, ElapsedEventArgs e) { Repeat2(); }
        public static string getweather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=8cbf2c0cf7cd1c17ae63ac6f87f2ffe0",city);
                var json = web.DownloadString(url);
                return json;
            }
        }
        public static void SetTimer()
        {
            aTimer = new Timer(60000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static void SetCount()
        {
            aTimer = new Timer(60000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static void Repeat()
        {
            string json = getweather();
            Root Weather = JsonSerializer.Deserialize<Root>(json);
            Console.Clear();
            Console.WriteLine("Update date: " + DateTime.Now);
            Console.WriteLine("City: " + Weather.name);
            Console.WriteLine("Temperature: " + (Weather.main.temp - 273.15).ToString("00.00") + "°C");
            Console.WriteLine("Pressure: " + Weather.main.pressure + "hPa");
            Console.WriteLine("Visibility: " + (Weather.visibility / 100) + "%");
            Console.WriteLine("Wind speed: " + Weather.wind.speed + "km/h");
            Console.WriteLine("Sky: " + Weather.weather[0].description);
            Console.WriteLine("\nNext update in: 59 seconds");
            bTimer = new Timer(1000);
            i = 59;
            bTimer.Elapsed += OnCountEvent;
            bTimer.AutoReset = true;
            bTimer.Enabled = true;
        }
        public static void Repeat2()
        {
            i--;
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Next update in: {0} seconds", i);
            if (i <= 0)
            {
                bTimer.Stop();
                bTimer.Dispose();
            }
        }
        public static void Main()
        {
            Console.WriteLine("Wpisz nazwę miasta: ");
            city = Console.ReadLine();
            Console.WriteLine("");
            Repeat();
            SetTimer();
            Console.ReadLine();
            //string json = getweather();
            //Root Weather = JsonSerializer.Deserialize<Root>(json);
            //Console.WriteLine("Name: " + Weather.name);
            aTimer.Stop();
            aTimer.Dispose();
        }
    }
}

//{"Date":"2019-08-01T00:00:00-07:00","Temperature":25,"Summary":"Hot"}
//https://api.openweathermap.org/data/2.5/weather?q=Słupsk&appid=8cbf2c0cf7cd1c17ae63ac6f87f2ffe0