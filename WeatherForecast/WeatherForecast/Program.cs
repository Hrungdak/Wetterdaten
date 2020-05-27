using System;
using WeatherForecast.ConsoleInteractionWithUser;
//using WeatherForecast.ConsoleInteractionWithUser;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInteractionHandler consolerinteractionhandler = new ConsoleInteractionHandler();
            consolerinteractionhandler.ManageConsoleInteraction();
            //ManageConsoleInteraction();
        }
    }
}
