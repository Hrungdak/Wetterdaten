using Functionalities;
using System;

namespace WeatherForecast.ConsoleInteractionWithUser
{
    public class ConsoleInteractionHandler
    {
        private string _userinput;
        private int _lowestGermanPostalCode = 01067;
        private int _highestGermanPostalCode = 99998;

        private Validation _userInputValidator = new Validation();

        public void ManageConsoleInteraction()
        {
            GreetUser();
            GetUserInput();
        }

        private void GreetUser()
        {
            Console.WriteLine("Hello User!");
        }

        private void GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter a postal Code within Germany!");
                _userinput = Console.ReadLine();
                if (_userinput == string.Empty)
                    break;

                if (_userInputValidator.IsInteger(_userinput))
                {
                    int zipcode = _userInputValidator.ConvertStringToInt(_userinput);
                    if (zipcode < _lowestGermanPostalCode ||
                        zipcode > _highestGermanPostalCode)
                    {
                        Console.WriteLine("This is not a valid Postal Code within Germany!");
                    }
                    else
                    {
                        Functionalities.WeatherForecast weatherForecast = new Functionalities.WeatherForecast();
                        Console.WriteLine(weatherForecast.GetWeatherForecastForZip(_userInputValidator.ConvertStringToInt(_userinput), ForecastTypeEnum.easy));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}