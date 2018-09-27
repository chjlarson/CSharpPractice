using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int hour = 10;
            bool isGoldCustomer = true;
            //float price;
            var season = Season.Autumn;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It is evening.");
            }

            //if (isGoldCustomer)
            //    price = 19.95f
            //else
            //    price = 29.95f

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            switch (season)
            {
                case Season.Autumn:
                    {
                        Console.WriteLine("It is Autumn.");
                        break;
                    }
                case Season.Summer:
                    {
                        Console.WriteLine("It is Summer");
                        break;
                    }
                case Season.Spring:
                    {
                        Console.WriteLine("It is Spring");
                        break;
                    }
                case Season.Winter:
                    {
                        Console.WriteLine("It is Winter");
                        break;
                    }
            }
        }
    }
}
