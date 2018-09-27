using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "c:\\temp\\myfile.jpg";

            File.Copy(path, "d:\\temp\\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("..");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            var path2 = "c:\\tmep\\folder1";

            Directory.CreateDirectory(path2);

            var files = Directory.GetFiles(path2, "*,*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(path2, "*,*", SearchOption.AllDirectories);
            foreach(var dir in directories)
                Console.WriteLine(dir);

             Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
