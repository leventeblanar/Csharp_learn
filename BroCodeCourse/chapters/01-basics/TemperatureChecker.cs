using System;

namespace Basics
{
    internal class TemperatureChecker
    {
        public static void Run()
        {
            Console.Write("What is your name? ");
            string? name = Console.ReadLine();

            Console.Write("What's the temperature? ");
            string? temperatureInput = Console.ReadLine();

            bool success = double.TryParse(temperatureInput, out double temperature);

            if (!success)
            {
                Console.WriteLine("Not valid temperature input");
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"Hello, {name}!");

            if (temperature < 0)
            {
                Console.WriteLine("It's freezing");
            }
            else if (temperature >= 0 && temperature <= 14)
            {
                Console.WriteLine("It's cold");
            }
            else if (temperature >= 15 && temperature <= 24)
            {
                Console.WriteLine("The weather is pleasant");
            }
            else
            {
                Console.WriteLine("It's hot");
            }
        }
    }
}