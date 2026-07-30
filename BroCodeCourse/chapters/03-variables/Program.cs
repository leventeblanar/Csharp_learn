using System;
using System.Security.Cryptography;

namespace Variables
{
    class Program
    {
        static void Main(string [] args)
        {
            int x; // declaration
            x = 123; //initialization

            int y = 321; // declaration and initialization

            int z = x + y;

            int age = 33; // whole integer
            double height = 300.5; // decimal number
            bool alive = true;
            char symbol = '@';
            String name = "Bro";

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);

            System.Console.WriteLine("Your age is " + age);
            System.Console.WriteLine("Your height is " + height + "cm");
            System.Console.WriteLine("Are you alive? -> " + alive);
            System.Console.WriteLine("Your symbol is: " + symbol);
            System.Console.WriteLine("My name is " + name);

            // CONSTANTS
            // Immutable values which are known at compile time
            // And do not change for the life of the program

            const double pi = 3.14159;

            Console.WriteLine(pi);
        }
    }
}