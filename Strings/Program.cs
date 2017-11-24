using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Meow";
            String name2 = "Meow2";
            string name3 = "Meow3";

            var fullName = firstName + " " + lastName;
            var fullName2 = string.Format("My name is {0} {1}", firstName, lastName);
            
            var names = new string[3] {"Mary", "John", "Toby"};
            var formatNames = string.Join(" ,", names);
            System.Console.WriteLine(formatNames);

            var text = @"Hi John
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text);

        }
    }
}