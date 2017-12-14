using System;

namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
        }
    }
}