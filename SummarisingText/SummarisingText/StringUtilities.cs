using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarisingText
{
    public class StringUtilities
    {
        public static string SummarizeText(string text, int maxLength)
        {

            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChar += word.Length + 1;
                if (totalChar > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + ". . .";
        }
    }
}
