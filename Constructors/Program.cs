using System;

namespace Constructors
{  
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            System.Console.WriteLine(customer.ID);
            System.Console.WriteLine(customer.Name);    

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}