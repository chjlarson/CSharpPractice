using System;
using CSharoFundamentals.Math;

namespace CSharoFundamentals
{

    class Program
    {
        //Enums
        public enum ShippingMethod
        {
            RegulaAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        static void Main(string[] args)
        {
            //Using classes
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            Calculator calc = new Calculator();
            var results = calc.Add(1, 2);
            Console.WriteLine(results);

            //Arrays
            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            //Strings
            string firstName = "Chris";
            var lastName = "Larson";

            var fullName = firstName + " " + lastName;

            var myfullName = string.Format("My name is {0} {1}", firstName, lastName);

            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths \nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            var text2 = @"Hi John
            Look into the following paths 
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text2);

            //Enums
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            //Reference types and value types
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("A: {0}, B: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3};
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


        }
    }
}
