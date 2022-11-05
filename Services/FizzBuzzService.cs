using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzz
    {
        public string FizzBuzz(int value)
        {
                // Can use StringBuilder when expecting a lot more concatenation due to the way C# handles string concat
                string result = "";
                if (value % 3 == 0)
                {
                    result += "Fizz";
                }
                if (value % 5 == 0)
                {
                    result += "Buzz";
                }
                return result;
        
    }
}
