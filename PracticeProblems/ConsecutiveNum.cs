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

            // Get the user inputs
            System.Console.WriteLine("Enter a few numbers separated by -'s: ");
            var input = Console.ReadLine().Split('-');

            // Set the inputs into the list
            foreach (var num in input)
            {
                numList.Add(Convert.ToInt32(num));
            }

            // Print whether the list is Consecutive or not
            var message = isConsecutive(numList) ? "Consecutive" : "Not Consecutive";
            System.Console.WriteLine(message);
        }

        public static bool isConsecutive (List<int> numList)
        {
            var consecutive = true;
            numList.Sort();

            // Determine if Consecutive 
            for (var i = 1; i < numList.Count; i++)
            {
                if (numList[i] != numList[i - 1] + 1)
                {
                    consecutive = false;
                }
            }

            return consecutive;
        }
    }
}