using System.IO;

namespace File
{
    class DirectoryVsDirInfo
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", ".", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", ".", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);
            }

            Directory.Exists("...");


            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}