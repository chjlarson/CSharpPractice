using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Defualt Constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overloaded Constructors
        // "this" used to pass the execution to another constructors in this class
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }
}
