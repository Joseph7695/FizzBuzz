using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    public class SpecificFizzBuzz : IFizzBuzzIterator
    {
        private int threeDivisibleIndex;
        private int fiveDivisibleIndex;
        private readonly StringBuilder result;
        public SpecificFizzBuzz(StringBuilder stringBuilder)
        {
            result = stringBuilder ?? throw new ArgumentNullException(nameof(result));
        }
        public string FizzBuzzIterate(int startValue, int endValue)
        {
            threeDivisibleIndex = startValue % 3;
            fiveDivisibleIndex= startValue % 5;
            result.Clear();
            for (int i = startValue; i <= endValue; i++)
            {
                if (threeDivisibleIndex != 0 && fiveDivisibleIndex != 0)
                {
                    result.Append(i);
                }
                else
                {
                    if (threeDivisibleIndex == 0)
                    {
                        result.Append("Fizz");
                    }
                    if (fiveDivisibleIndex == 0)
                    {
                        result.Append("Buzz");
                    }
                }
                
                result.AppendLine();
                threeDivisibleIndex = (threeDivisibleIndex + 1) % 3;
                fiveDivisibleIndex = (fiveDivisibleIndex + 1) % 5;
            }
            return result.ToString();
        }
    }
}
