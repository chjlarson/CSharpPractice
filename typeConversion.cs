using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int q = 1;
            byte w = (byte) q;
            Console.WriteLine(w);

            string number = "1234";
            int e = Conver.ToInt32(number);
            Console.WriteLine(e);

            try 
            {
                var number2 = "1234";
                byte r = Convert.ToByte(number);
                Console.WriteLine(number2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number will not be converted");
            }

            try
            {
                string str = "true";
                bool t = Convert.ToBoolean(str);
                Console.WriteLine(t);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted");
            }
        }
    }
}