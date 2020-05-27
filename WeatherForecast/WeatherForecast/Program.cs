using WeatherForecast.ConsoleInteractionWithUser;

namespace WeatherForecast
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConsoleInteractionHandler consoleInteractionHandler = new ConsoleInteractionHandler();
            consoleInteractionHandler.ManageConsoleInteraction();
        }
    }
}