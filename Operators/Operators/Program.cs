using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 1;
            var d = 2;
            var e = 3;

            Console.WriteLine(a + b);

            //Both are ints so they will output an int
            Console.WriteLine(a / b);

            //Both are floats so they will output a float
            Console.WriteLine((float)a / (float)b);

            //Operator precedence 
            Console.WriteLine(c + d * e);
            Console.WriteLine((c + d) * e);
            Console.WriteLine(a > b);
            Console.WriteLine(a ==b);
            Console.WriteLine(a != b);

            //This is sloppy because of double negative
            Console.WriteLine(!(a != b));

            //Logical operators
            Console.WriteLine(a > b && c> a);
            Console.WriteLine(a > b && c == a);
            Console.WriteLine(a > b || c == a);

            Console.WriteLine(!(a > b && c == a));
        }
    }
}
