using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    class Duplicatefinder
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
            /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
            /// any duplicates. If so, display "Duplicate" on the console.
            /// </summary>

            var numList = new List<int>();
            var uniques = new List<int>();
            var duplicates = false;

            Console.Write("Enter a few numbers separated by a '-'");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
            
            foreach (var num in input.Split('-'))
            {
                numList.Add(Convert.ToInt32(num));
            }

            foreach (var num in numList)
            {
                if (!uniques.Contains(num))
                {
                    uniques.Add(num);
                }
                else
                {
                    duplicates = true;
                    break;
                }
            }

            if (duplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }
    }
}