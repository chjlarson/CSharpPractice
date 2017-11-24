using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person();

            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            Calculator calc = new Calculator();
            var result = calc.Add(2, 4);
            Console.WriteLine(result);
        }
    }
}