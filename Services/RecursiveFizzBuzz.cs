using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    public class RecursiveFizzBuzz : IFizzBuzzIterator
    {
        private readonly IFizzBuzz fizzBuzz;
        private readonly StringBuilder result;
        public RecursiveFizzBuzz(IFizzBuzz fizzBuzz, StringBuilder stringBuilder)
        {
            this.fizzBuzz = fizzBuzz ?? throw new ArgumentNullException(nameof(fizzBuzz));
            result = stringBuilder ?? throw new ArgumentNullException(nameof(result));
        }

        public string FizzBuzzIterate(int startValue, int endValue)
        {
            return FizzBuzzRecursiveIterate(endValue, startValue);
        }

        private string FizzBuzzRecursiveIterate(int endValue, int i)
        {
            if (i <= endValue)
            {
                result.AppendLine(fizzBuzz.FizzBuzz(i));
                return FizzBuzzRecursiveIterate(endValue, i + 1);
            }
            else
            {
                return result.ToString();
            }
        }
    }
}
