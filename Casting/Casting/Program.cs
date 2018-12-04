using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            /*
                Text text = new Casting.Text();
                Shape shape = text;

                text.Width = 200;
                shape.Width = 100;

                Console.WriteLine(text.Width);
            

                StreamReader reader = new StreamReader(new MemoryStream());

                var list = new ArrayList();
                list.Add(1);
                list.Add("Chris");
                list.Add(new Text());

                var anotherList = new List<int>();
            */
            //Doncasting

                Shape shape = new Text();
                Text text = (Text)shape;
                

        }
    }
}
