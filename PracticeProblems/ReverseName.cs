using System;

namespace PracticeProblems
{
    class ReverseName
    {
        public static void Main(string[] args)
        {
            System.Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseNames(name);
            System.Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseNames(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - 1] = name[i -1];
            }

            return new string(array);
        }
    }
}