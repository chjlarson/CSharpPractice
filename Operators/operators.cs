using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] agrs)
        {
            var a = 10;
            var b = 3;
            var c = 2;

            Console.WriteLine((a + b) * c);
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(!(a != b));
            Console.WriteLine(c > b || c == a);
        }
    }
}