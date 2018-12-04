using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        /*
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }
        */
        public Vehicle(string registrationNumer)
        {
            _registrationNumber = registrationNumer;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumer);
        }
    }
}
