using System;
using System.ComponentModel;

namespace Functionalities
{
    public class Validation
    {
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
            if (forecastType < 0)
            {
                return false;
            }
            if (temperatureType < 0)
            {
                return false;
            }
            return true;
        }
    }
}