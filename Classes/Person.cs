using System; 

namespace Classes
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0},", to);
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.firstName = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.firstName = "John";
            person.Introduce("Mosh");
            var person2 = Person.Parse("John2");
        }

    }
}