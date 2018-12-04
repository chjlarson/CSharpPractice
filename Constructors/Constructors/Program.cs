﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
        class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(12, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);

            var car = new Car("500");
        }
    }
}    
