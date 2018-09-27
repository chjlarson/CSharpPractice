using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            //Append() and AppendLine()
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //Replace
            builder.Replace('-', '+');
            Console.WriteLine(builder);

            //Remove()
            builder.Remove(0, 10);
            Console.WriteLine(builder);

            //Insert()
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            //Indexer
            Console.WriteLine("First Char: " + builder[0]);

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);
        }
    }
}
