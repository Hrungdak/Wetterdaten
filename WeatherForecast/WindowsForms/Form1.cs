using System;
using System.Windows.Forms;
using Functionalities;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private int _userZipCode;
        private int _userForecastPreference;
        private int _userTemperaturePreference;

        public Form1()
        {
            InitializeComponent();
            GreetingUser greetingUser = new GreetingUser(this);
            greetingUser.Show();
            this.Opacity = 0;
            this.Visible = false;
        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {
        }

        public void GetUserSettings()
        {
            _userZipCode = Properties.Settings.Default.userZipcode;
            _userForecastPreference = Properties.Settings.Default.userForecastPreference;
            _userTemperaturePreference = Properties.Settings.Default.userTemperatureTypePreference;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.userZipcode = _userZipCode;
            Properties.Settings.Default.userForecastPreference = _userForecastPreference;
            Properties.Settings.Default.userTemperatureTypePreference = _userTemperaturePreference;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            ForecastTypeEnum type = ForecastTypeEnum.easy;
            _userForecastPreference = (int)ForecastTypeEnum.easy;
            if (stuendlichButton.Checked)
            {
                type = ForecastTypeEnum.hourly;
                _userForecastPreference = (int)ForecastTypeEnum.hourly;
            }
            if (dreiTageButton.Checked)
            {
                type = ForecastTypeEnum.threeDays;
                _userForecastPreference = (int)ForecastTypeEnum.threeDays;
            }
            if (vierzehnTageButton.Checked)
            {
                type = ForecastTypeEnum.fourteenDays;
                _userForecastPreference = (int)ForecastTypeEnum.fourteenDays;
            }

            TemperatureTypeEnum temperatureType = TemperatureTypeEnum.Celsius;
            _userTemperaturePreference = (int)TemperatureTypeEnum.Celsius;
            if (kelvinButton.Checked)
            {
                temperatureType = TemperatureTypeEnum.Kelvin;
                _userTemperaturePreference = (int)TemperatureTypeEnum.Kelvin;
            }

            WeatherForecast weatherForecast = new WeatherForecast();
            Validation inputValidator = new Validation();
            if (inputValidator.IsInteger(userinputfield.Text))
            {
                _userZipCode = inputValidator.ConvertStringToInt(userinputfield.Text);
                var result = weatherForecast
                    .GetWeatherForecastForZip(
                    _userZipCode,
                    type,
                    temperatureType);
                outputfield.Text = string.Join(Environment.NewLine, result);
            }

            SaveSettings();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUserSettings();
            Validation validation = new Validation();
            if (validation.areUserSettingsValid(Properties.Settings.Default.userName,
                _userZipCode,
                _userForecastPreference,
                _userTemperaturePreference))
            {
                //ToDo: If userSettings are set, automatically call weatherforecast(...) with those Settings
                userinputfield.Text = "" + _userZipCode;
                SetForecastButton();
                SetTemperatureButton();
            }
        }

        private void SetForecastButton()
        {
            //ToDo set correct Radiobutton based on _userForecastPreference
        }

        private void SetTemperatureButton()
        {
            //ToDo set correct Radiobutton based on _userTemperaturePreference;
        }
    }
}