using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next(1, 10));
            }

            for (var j = 0; j < 10; j++)
            {
                System.Console.Write((char)('a' + random.Next(0, 26)));
            }

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var k = 0; k < passwordLength; k++)
            {
                buffer[k] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
        }
    }
}