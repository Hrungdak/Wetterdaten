using System;

namespace WeatherForecast.ConsoleInteractionWithUser
{
    public class ConsoleInteractionHandler
    {
        private string _userinput;
        private int _lowestGermanPostalCode = 01067;
        private int _highestGermanPostalCode = 99998;

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
            Console.WriteLine("Please enter a postal Code within Germany!");
            _userinput = Console.ReadLine();
            if (_userinput == string.Empty)
                Environment.Exit(0);

            int convertedInputToInt;
            bool isUserInputNumber = int.TryParse(_userinput, out convertedInputToInt);

            if (isUserInputNumber)
            {
                if (convertedInputToInt < _lowestGermanPostalCode || convertedInputToInt > _highestGermanPostalCode)
                {
                    Console.WriteLine("This is not a valid Postal Code within Germany!");
                }
                else
                    //TODO
                    Console.WriteLine("Für " + convertedInputToInt + " konnten noch keine Wetterdaten abgerufen werden.");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
            GetUserInput();
        }
    }
}