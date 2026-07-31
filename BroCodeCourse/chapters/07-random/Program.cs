using System;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}