using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast.ConsoleInteractionWithUser
{
    public class ConsoleInteractionHandler
    {
        private string userinput;
        private int lowestGermanPostalCode = 01067;
        private int highestGermanPostalCode = 99998;
        public string test;

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
            userinput = Console.ReadLine();
            if(userinput == String.Empty)
                System.Environment.Exit(0);

            int convertedInputToInt;
            bool isUserInputNumber = Int32.TryParse(userinput, out convertedInputToInt);

            if (isUserInputNumber)
            {
                if (convertedInputToInt < lowestGermanPostalCode || convertedInputToInt > highestGermanPostalCode)
                {
                    Console.WriteLine("This is not a valid Postal Code within Germany!");
                    GetUserInput();
                }
                else
                    //TODO
                    Console.WriteLine("Für " + convertedInputToInt + " konnten noch keine Wetterdaten abgerufen werden.");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                GetUserInput();
            }
        }
    }
}
