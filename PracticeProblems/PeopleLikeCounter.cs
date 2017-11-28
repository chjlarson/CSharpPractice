using System;
using System.Collections.Generic;

namespace PractiveProblems
{
    class PeopleLikeCounter
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
            /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            /// </summary>

            var names = new List<string>();

            while (true)
            {
                System.Console.WriteLine("Type a name or select ENTER to finish");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);
            }

            if (names.Count > 2)
            {
                System.Console.WriteLine("{0} {1} and {2} other like your post", names[0], names[1], names.Count - 2);
            }
            else if (names.Count == 2)
            {
                System.Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                System.Console.WriteLine("{0} likes your post", names[0]);
            }
            else
            {
                System.Console.WriteLine();
            }
        }
    }
}