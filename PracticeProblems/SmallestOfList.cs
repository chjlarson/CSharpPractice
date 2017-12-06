using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    class SmallestOfList
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
            /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            /// the 3 smallest numbers in the list.
            /// 
            /// </summary>

            string[] elements;

            while(true)
            {
                System.Console.Write("Please enter a list of coma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                    {
                        break;
                    }
                }

                System.Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();

            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallest = SmallestFromList(numbers, 3);

            System.Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallest)
            {
                System.Console.WriteLine(number);
            }
        }

        public static List<int> SmallestFromList (List<int> numbers, int count)
        {
            var smallest = new List<int>();
            while (smallest.Count < count)
            {
                // Assume the first number is the smallest
                var min = numbers[0];

                foreach(var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }

                    smallest.Add(min);
                    numbers.Remove(min);
                }
            }

            return smallest;
        }
    }
}