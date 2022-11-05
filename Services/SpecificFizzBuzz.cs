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
        public string FizzBuzzIterate(int startValue, int endValue)
        {
            threeDivisibleIndex = startValue % 3;
            fiveDivisibleIndex= startValue % 5;
            for (int i = startValue; i <= endValue; i++)
            {

            }
        }
    }
}
