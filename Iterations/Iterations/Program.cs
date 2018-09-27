using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            var numbers = new int[] {1, 2, 3, 4};


            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (var j = 10; j >= 1; j--)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
            }

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var b = 0;
            while (b <= 10)
            {
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
                b++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine("@Echo: " + input);
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }

        }
    }
}
