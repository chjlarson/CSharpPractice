using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            Console.Write("Ener a word");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>();
            var vowelCount = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}