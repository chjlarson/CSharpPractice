using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);

            //Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effects of Copy()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effects of Sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effects of Reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
