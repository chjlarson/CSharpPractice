using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int j = 1;
            byte e = (byte)j;
            Console.WriteLine(e);

            int k = 1000;
            byte d = (byte)k;
            Console.WriteLine(d);

            var number = "1234";
            var h = Convert.ToInt32(number);
            Console.WriteLine(h);

            try
            {
                byte a = Convert.ToByte(number);
                Console.WriteLine(a);

                string str = "true";
                bool q = Convert.ToBoolean(str);
            }
            catch (Exception)
            {
                Console.WriteLine("The number cannot be converted to a Byte");
                return;
            }

            //Will not be displayed because of the first try catch block
            try
            {
                string str = "true";
                bool q = Convert.ToBoolean(str);
                Console.WriteLine(q);
            }
            catch (Exception)
            {

                Console.WriteLine("The number cannot be converted to a Boolean");
            }
        }
    }
}
