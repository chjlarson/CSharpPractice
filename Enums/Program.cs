using System;

namespace enums
{
    public enum ShippingMethod
    {
        Airmail = 1,
        Express = 2,
        Super = 3
    }
    class Program
    {
        static void Main(String[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            System.Console.WriteLine((ShippingMethod)methodID);
            System.Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
    
}