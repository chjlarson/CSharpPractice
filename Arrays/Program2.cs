using System;

namespace Arrays
{
    class Program2
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 2, 14, 6};

            // Length
            System.Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            System.Console.WriteLine("Effects of Clear()");
            foreach(var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            System.Console.WriteLine("Effects of Copy()");
            foreach (var n in another)
            {
                System.Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);

            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);

            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }
        }
    }
}