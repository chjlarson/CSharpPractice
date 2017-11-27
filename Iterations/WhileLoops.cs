using System;

namespace Iterations
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            var j = 0;
            while (j <= 10)
            {
                if (j%2 == 0)
                {
                    System.Console.WriteLine(j);
                }
            }

            while (true)
            {
                System.Console.Write("Type your name ");
                var input = System.Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo " + input);
                    continue;
                }

                break;
            }
        }
    }
}