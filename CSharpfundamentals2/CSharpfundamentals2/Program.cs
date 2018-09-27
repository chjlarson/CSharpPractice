using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpfundamentals2
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            var random = new Random();
            char[] buffer = new char[10];
            var passwordLength = 10

            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld (Person person)
        {
            person.Age += 10;
        }
    }
}
