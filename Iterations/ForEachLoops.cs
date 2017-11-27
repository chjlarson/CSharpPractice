namespace Iterations
{
    class ForEachLoops
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            var numbers = new int[] {1, 2, 3, 4};

            foreach (var character in name)
            {
                System.Console.WriteLine(character);
            }

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}