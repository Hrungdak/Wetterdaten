using System;
using System.Windows.Forms;
using Functionalities;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (heuteEinfachButton.Checked)
            {
                WeatherData weatherData = new WeatherData();
                outputfield.Text = weatherData.GetWeatherForecastForZip(int.Parse(userinputfield.Text));
            }
            else
            {
                outputfield.Text = "Für diesen Menupunkt ist noch keine Funktionalität vorhanden.";
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}