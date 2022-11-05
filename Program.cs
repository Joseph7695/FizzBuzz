using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using System;
using System.Text;

namespace FizzBuzz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzz fizzBuzz = new FizzBuzzService();
            StringBuilder stringBuilder = new StringBuilder();

            // Solution 1: For loop
            IFizzBuzzIterator forLoopFizzBuzz = new IterativeFizzBuzz(fizzBuzz, stringBuilder);
            string result1 = forLoopFizzBuzz.FizzBuzzIterate(1, 100);

            // Solution 2: Recursive loop
            IFizzBuzzIterator recursiveFizzBuzz = new RecursiveFizzBuzz(fizzBuzz, stringBuilder);
            string result2 = recursiveFizzBuzz.FizzBuzzIterate(1, 100);

            // Solution 3: More specific, skip the checking
        }


    }
}