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
            ForecastTypeEnum type = ForecastTypeEnum.easy;
            if (stuendlichButton.Checked)
            {
                type = ForecastTypeEnum.hourly;
            }
            if (dreiTageButton.Checked)
            {
                type = ForecastTypeEnum.threeDays;
            }
            if (vierzehnTageButton.Checked)
            {
                type = ForecastTypeEnum.fourteenDays;
            }

            TemperatureTypeEnum temperatureType = TemperatureTypeEnum.Celsius;
            if (kelvinButton.Checked)
            {
                temperatureType = TemperatureTypeEnum.Kelvin;
            }

            WeatherForecast weatherForecast = new WeatherForecast();
            Validation inputValidator = new Validation();
            if (inputValidator.IsInteger(userinputfield.Text))
            {
                var result = weatherForecast
                    .GetWeatherForecastForZip(
                    inputValidator.ConvertStringToInt(userinputfield.Text),
                    type,
                    temperatureType);
                outputfield.Text = string.Join(Environment.NewLine, result);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}