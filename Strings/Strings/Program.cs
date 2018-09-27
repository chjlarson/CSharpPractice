using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Chris Larson ";

            //Trim()
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            //ToUpper()
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            //IndexOf() amd Substring()
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name:" + firstName);
            Console.WriteLine("Last Name:" + lastName);

            //Split()
            var names = fullName.Split(' ');
            Console.WriteLine("First Name:" + names[0]);
            Console.WriteLine("Last Name:" + names[1]);

            //Replace()
            Console.WriteLine(fullName.Replace("Chris", "Christopher"));

            //IsNullOrEmpty() or IsNullOrWhiteSpace
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("invalid");
            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("invalid");
            }

            //Convert
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine( price.ToString("C0"));

        }
    }
}
