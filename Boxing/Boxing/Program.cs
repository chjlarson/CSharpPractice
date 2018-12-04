using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            //Value type - Boxing is being done because list.Add method takes an argument of type object
            list.Add(1);
            //Boxing will not happen
            list.Add("Chris");
            //Boxing will happen
            list.Add(DateTime.Today);

            // Unboxing will happen
            var number = (int)list[1];

            //Type safety, so no boxing will happen, so no performance penalty
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add();

        }
    }
}
