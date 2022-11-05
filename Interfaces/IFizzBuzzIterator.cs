using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Interfaces
{
    interface IFizzBuzzIterator
    {
        /// <summary>
        /// Method of iteration for the values
        /// </summary>
        /// <param name="startValue">Start value</param>
        /// <param name="endValue">End value (Inclusive)</param>
        /// <returns></returns>
        string FizzBuzzIterate(int startValue, int endValue);
    }
}
