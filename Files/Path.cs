using System.IO;

namespace Files
{
    class Path
    {
        static void Main(string[] args)
        {
            var path = @"c:\Projects\CSharpFudamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            System.Console.WriteLine("Extension: " + Path.GetExtension(path));
            System.Console.WriteLine("File Name: " + Path.GetFileName(path));
            System.Console.WriteLine("File name without extension: " + Path.GetExtensionWithoutExtension(path));
            System.Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}