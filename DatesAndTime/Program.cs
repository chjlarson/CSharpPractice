using System;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            System.Console.WriteLine("Hour: " + now.Hour);
            System.Console.WriteLine("Minute: " + now.Minute);

            var tomorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }
    }
}