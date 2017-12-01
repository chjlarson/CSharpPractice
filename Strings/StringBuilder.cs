using System;

namespace Strings
{
    class StringBuilder
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            // Because all the methods return a StringBuilder we can keep calling methods together. 
            // Append()
            builder.Append('-',10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-',10)

                // Replace()
                .Replace('-', '+')

                // Remove()
                .Remove(0, 10)

                // Insert()
                .Insert(0, new string('-', 10));

            System.Console.WriteLine("First builder: " + builder[0]);
            System.Console.WriteLine(builder);

        }
    }
}