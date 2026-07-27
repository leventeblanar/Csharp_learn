using System;

namespace Basics
{
    internal class AgeChecker
    {
        public static void Run()
        {
            Console.WriteLine("What's your name? ");
            string? name = Console.ReadLine();

            Console.Write("How old are you? ");
            string? ageInput = Console.ReadLine();

            bool success = int.TryParse(ageInput, out int age);

            Console.Write("Thank you! ");

            if (!success)
            {
            Console.WriteLine("Invalid age.");
            return;
            }

            Console.WriteLine();
            Console.WriteLine($"Hello, {name}!");

            if (age >= 18)
            {
                Console.WriteLine("You are old enough.");
            }
            else
            {
                Console.WriteLine("You are not old enough.");
            }
        }
    }
}