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
            Properties.Settings.Default.Save();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            ForecastTypeEnum type = ForecastTypeEnum.easy;
            _userForecastPreference = (int)ForecastTypeEnum.easy;
            if (hourlyButton.Checked)
            {
                type = ForecastTypeEnum.hourly;
                _userForecastPreference = (int)ForecastTypeEnum.hourly;
            }
            if (threeDayButton.Checked)
            {
                type = ForecastTypeEnum.threeDays;
                _userForecastPreference = (int)ForecastTypeEnum.threeDays;
            }
            if (fourteenDayButton.Checked)
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
                SetUserPreferencesOptions();
                RunWeatherForecastWithUserPreferences();
            }
        }

        private void SetUserPreferencesOptions()
        {
            userinputfield.Text = _userZipCode.ToString();
            SetForecastPreferenceButton();
            SetTemperaturePreferenceButton();
        }

        private void RunWeatherForecastWithUserPreferences()
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            var result = weatherForecast
                .GetWeatherForecastForZip(
                GetZipcodeFromSettings(),
                GetForecastTypeFromSettings(),
                GetTemperatureTypeFromSettings());
            outputfield.Text = string.Join(Environment.NewLine, result);
        }

        private int GetZipcodeFromSettings()
        {
            return Properties.Settings.Default.userZipcode;
        }

        private void SetForecastPreferenceButton()
        {
            switch (_userForecastPreference)
            {
                case 0:
                    easyButton.Checked = true;
                    break;

                case 1:
                    hourlyButton.Checked = true;
                    break;

                case 2:
                    threeDayButton.Checked = true;
                    break;

                case 3:
                    fourteenDayButton.Checked = true;
                    break;
            }
        }

        private void SetTemperaturePreferenceButton()
        {
            switch (_userTemperaturePreference)
            {
                case 0:
                    celsiusButton.Checked = true;
                    break;

                case 1:
                    kelvinButton.Checked = true;
                    break;
            }
        }

        private ForecastTypeEnum GetForecastTypeFromSettings()
        {
            ForecastTypeEnum type = ForecastTypeEnum.easy;
            switch (Properties.Settings.Default.userForecastPreference)
            {
                case 0:
                    {
                        type = ForecastTypeEnum.easy;
                        break;
                    }
                case 1:
                    {
                        type = ForecastTypeEnum.hourly;
                        break;
                    }
                case 2:
                    {
                        type = ForecastTypeEnum.threeDays;
                        break;
                    }
                case 3:
                    {
                        type = ForecastTypeEnum.fourteenDays;
                        break;
                    }
            }
            return type;
        }

        private TemperatureTypeEnum GetTemperatureTypeFromSettings()
        {
            TemperatureTypeEnum temperaturetype = TemperatureTypeEnum.Celsius;
            switch (Properties.Settings.Default.userTemperatureTypePreference)
            {
                case 0:
                    {
                        temperaturetype = TemperatureTypeEnum.Celsius;
                        break;
                    }
                case 1:
                    {
                        temperaturetype = TemperatureTypeEnum.Kelvin;
                        break;
                    }
                case 2:
                    {
                        temperaturetype = TemperatureTypeEnum.Fahrenheit;
                        break;
                    }
            }
            return temperaturetype;
        }
    }
}