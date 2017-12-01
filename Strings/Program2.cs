using System;

namespace Strings
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Trim(), ToUpper(), and ToLower()
            var fullname = "Nosh Meow ";
            System.Console.WriteLine("Trim: '{}'", fullname.Trim());
            System.Console.WriteLine("ToUpper: '{}'", fullname.Trim().ToUpper());
            System.Console.WriteLine("ToLower: '{}'", fullname.Trim().ToLower());
            
            // IndexOf() and Substring()
            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: " + lastName);
            
            // Split()
            var names = fullname.Split(' ');
            System.Console.WriteLine("First Name: " + names[0]);
            System.Console.WriteLine("Last Name: " + names[1]);

            // Replace()
            System.Console.WriteLine(fullname.Replace("Mosh", "Moshi"));
            fullname.Replace('o', '0');

            // IsNullOrempty()
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                System.Console.WriteLine("Invalid");
            }

            // IsNullOrWhiteSpace
            if (String.IsNullOrWhiteSpace(" "))
            {
                System.Console.WriteLine("Invalid");
            }

            // Convert
            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            price.ToString("C");

        }
    }
}