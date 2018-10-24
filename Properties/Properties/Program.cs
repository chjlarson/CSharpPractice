using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1989, 1, 1));
            //This can nly be used if the Brthdate was public
            //var person = new Person(1989, 1, 1);
            //person.Birthdate = new DateTime(1989, 1, 1);

            Console.WriteLine(person.Age);
        }
    }
}
