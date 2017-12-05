using System;

namespace PracticeProblems
{
    class PascalCase
    {
        static void Main(string[] args)
        {
             /// <summary>
            /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
            /// create a variable name with PascalCase convention. For example, if the user types: 
            /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
            /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
            /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
            /// </summary>

            Console.Write("Ente a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordPC = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordPC;
            }

            Console.WriteLine(variableName);
        }
    }
}