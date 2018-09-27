using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxLength = 20;
            var sentence = "This is going to be a really really really really really really really really really really really really really really really really really really really really really really really really really really really really really really long text";
            var summary = StringUtilities.SummarizeText(sentence, maxLength);
            Console.WriteLine(summary);
        }
    }
}
