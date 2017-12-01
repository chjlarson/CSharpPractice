using System;
using System.Collections.Generic;

namespace Strings
{
    public class SummerizeText
    {
        static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;            
            }
            
            // text.Substring(0, maxLength);

            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalChar += word.length + 1;
                if (totalChar > maxLength)
                {
                    break;
                }
            }

            return String.join(" ", summaryWords) + "...";
        }
    }
}

