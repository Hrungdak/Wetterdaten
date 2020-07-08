using Functionalities.Enums;

using System;

namespace Functionalities.DomainLogic
{
    public class DomainValidation
    {
        //ToDo: Seperate into DOmain-Validation & UI-Validation
        public bool IsInteger(string value)
        {
            return int.TryParse(value, out int convertedInputToInt);
        }

        public int ConvertStringToInt(string value)
        {
            if (IsInteger(value))
            {
                return int.Parse(value);
            }

            throw new ArgumentException();
        }

        public bool areUserSettingsValid(string userName, int zipcode, int forecastType, int temperatureType)
        {
            if (userName == null || userName == string.Empty)
            {
                return false;
            }
            if (zipcode < 0)
            {
                return false;
            }
            if (forecastType < 0 || forecastType > Enum.GetNames(typeof(ForecastTypeEnum)).Length)
            {
                return false;
            }
            if (temperatureType < 0 || temperatureType > Enum.GetNames(typeof(TemperatureTypeEnum)).Length)
            {
                return false;
            }
            return true;
        }

        public bool isZipcode(int zipcode)
        {
            if (zipcode < 00501 || zipcode > 99950)
            {
                return false;
            }
            return true;
        }

        public bool isStringADate(string date)
        {
            DateTime dateTime;
            if (DateTime.TryParse(date, out dateTime))
            {
                return true;
            }
            return false;
        }
    }
}