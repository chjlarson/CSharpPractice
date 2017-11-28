using System;

namespace PracticeProblems
{
    class ReverseName
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - 1] = name[i -1];
            }

            var reversed = new string(array);
            System.Console.WriteLine("Reversed name: " + reversed);
        }
    }
}