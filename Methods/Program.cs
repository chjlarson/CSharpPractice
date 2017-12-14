using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           //var number = int.Parse("abc");
           var result = int.TryParse("abc", out number);
           if (result)
           {
               System.Console.WriteLine(number);
           }
           else
           {
               System.Console.WriteLine("Conversion failed");
           }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1,2));
            System.Console.WriteLine(calculator.Add(1,2,3));
            System.Console.WriteLine(calculator.Add(1,2,3,4);
            System.Console.WriteLine(calculator.Add(new int[]{1,2,3,4,5}));
            
        }

        static void UsePoints()
        {
             try
            {
                var point = new Point(10,20);
                point.Move(new Point(20, 60));
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}