using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    class ConsecutiveNum
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen.
            /// Workout if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            /// display a message: "Consecutive"; otherwise, display "Non Consecutive".
            /// </summary>

            // List of user inputs
            var numList = new List<int>();
            var consecutive = true;

            // Get the user inputs
            System.Console.WriteLine("Enter a few numbers separated by -'s: ");
            var input = Console.ReadLine().Split('-');

            // Set the inputs into the list
            foreach (var num in input)
            {
                numList.Add(Convert.ToInt32(num));
            }

            // Determine if Consecutive 
            for (var i = 0; i < numList.Count - 1; i++)
            {
                
            }

            // Print whether the list is Consecutive or not
            if (consecutive)
            {
                System.Console.WriteLine("Consecutive");
            }
            else
            {
                System.Console.WriteLine("Non Consecutive");
            }
        }
    }
}