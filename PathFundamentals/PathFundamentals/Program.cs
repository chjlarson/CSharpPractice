using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\Project\CSF\HelloWorld\HelloWorld.sin";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name w/o extension: " + Path.GetDirectoryName(path));

        }
    }
}
