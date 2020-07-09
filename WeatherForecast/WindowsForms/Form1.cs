﻿using Functionalities.DomainLogic;
using Functionalities.Enums;

using System;
using System.Linq;

//using System.Net.Http;
using System.Windows.Forms;

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
            SaveZipcodeList();
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

            WeatherForecastDomainService weatherService = new WeatherForecastDomainService();
            var inputValidator = new DomainValidation();
            if (inputValidator.IsInteger(userinputfield.Text))
            {
                //ToDo: Give Correct Date as Parameter
                _userZipCode = inputValidator.ConvertStringToInt(userinputfield.Text);
                //var result = weatherForecast
                //    .GetWeatherForecastForZip(
                //    _userZipCode,
                //    type,
                //    temperatureType);
                var result = weatherService
                    .GetForecast(
                    _userZipCode,
                    DateTime.Now,
                    temperatureType,
                    type);

                outputfield.Text = string.Join(Environment.NewLine, result);
            }

            SaveSettings();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUserSettings();
            var validation = new DomainValidation();
            if (validation.AreUserSettingsValid(Properties.Settings.Default.userName,
                _userZipCode,
                _userForecastPreference,
                _userTemperaturePreference))
            {
                SetUserPreferencesOptions();
                LoadZipcodeList();
                //ToDo for each Zipcode in the list, call RunWeatherforecast. Return Favourite Outputs in different TextLabel
                // 1) make new Textlabel
                // 2) Method RunWeatherforcecastFavourites
                // 3) Method loops over the favouriteList and calls WeatherForecastForZip
                RunWeatherForecastWithUserPreferences();
            }
        }

        //ToDo All Settings should be done in DomainService
        private void SetUserPreferencesOptions()
        {
            userinputfield.Text = _userZipCode.ToString();
            SetForecastPreferenceButton();
            SetTemperaturePreferenceButton();
        }

        private void RunWeatherForecastWithUserPreferences()
        {
            //ToDo: Give Correct Date as Parameter
            //WeatherForecast weatherForecast = new WeatherForecast();
            WeatherForecastDomainService weatherService = new WeatherForecastDomainService();
            var result = weatherService
                .GetForecast(
                GetZipcodeFromSettings(),
                DateTime.Now,
                GetTemperatureTypeFromSettings(),
                GetForecastTypeFromSettings());
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (favouritesList.SelectedItem != null)
            {
                favouritesList.Items.Remove(favouritesList.SelectedItem.ToString());
                SaveZipcodeList();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var inputValidator = new DomainValidation();
            if (inputValidator.IsInteger(userinputfield.Text))
            {
                favouritesList.Items.Add(userinputfield.Text);
                SaveZipcodeList();
            }
        }

        private void SaveZipcodeList()
        {
            var indices = favouritesList.Items.Cast<string>().ToArray();

            Properties.Settings.Default.userZipcodeList = string.Join(",", indices);
        }

        private void LoadZipcodeList()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userZipcodeList))
            {
                Properties.Settings.Default.userZipcodeList.Split(',')
                    .ToList()
                    .ForEach(item =>
                    {
                        favouritesList.Items.Add(item);
                    });
            }
        }
    }
}