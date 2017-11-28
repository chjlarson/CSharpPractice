using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    class UniqueNum
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
            /// include duplicates. Display the unique numbers that the user has entered.
            /// </summary> 

            var numbers = new List<int>();

            while (true)
            {
                System.Console.Write("Enter in a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            System.Console.WriteLine("Unique nummbers:");
            foreach (var number in uniques)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}