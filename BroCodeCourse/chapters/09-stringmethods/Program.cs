using System;
using Microsoft.VisualBasic;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Lakatos József";
            // String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //String username = fullName.Insert(0, "Mr.")
            // phoneNumber = phoneNumber.Replace("-", "/");
            // int fullNameLength = fullName.Length;
            // Console.WriteLine(fullNameLength);
            // Console.WriteLine(phoneNumber);

            String lastName = fullName.Substring(0, 7);
            String FirstName = fullName.Substring(8, 6);

            Console.WriteLine(lastName);
            Console.WriteLine(FirstName);

        }
    }
}