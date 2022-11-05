using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    internal class IterativeFizzBuzz : IFizzBuzzIterator
    {
        private readonly IFizzBuzz fizzBuzz;
        private readonly StringBuilder result;
        public IterativeFizzBuzz(IFizzBuzz fizzBuzz, StringBuilder stringBuilder)
        {
            this.fizzBuzz = fizzBuzz ?? throw new ArgumentNullException(nameof(fizzBuzz));
            result = stringBuilder ?? throw new ArgumentNullException(nameof(result));
        }

        public string FizzBuzzIterate(int startValue, int endValue)
        {
            for (int i = startValue; i <= endValue; i++)
            {
                result.AppendLine(fizzBuzz.FizzBuzz(i));
            }
            return result.ToString();
        }
    }
}
