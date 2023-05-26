using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace WeatherAppGui
{
    public partial class WelcomeScreen : Form
    {
        public string city;
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void initialize()
        {
            if (CityInput.TextLength > 0)
            {
                if (Error.Visible == true) Error.Visible = false;
                city = CityInput.Text;
                MainScreen MainWindow = new MainScreen(city);
                Hide();
                MainWindow.ShowDialog();
                Close();
            }
            else
            {
                Error.Visible = true;
            }
        }
        private void FindCity_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void CityInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData.ToString() == Key.Return.ToString())
            {
                initialize();
            }
        }
    }
}
