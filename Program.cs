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
            // Most generalized solution, the fizzBuzz checking logic is seperated from the iterating part
            IFizzBuzzIterator forLoopFizzBuzz = new IterativeFizzBuzz(fizzBuzz, stringBuilder);
            string result1 = forLoopFizzBuzz.FizzBuzzIterate(1, 100);
            Console.WriteLine(result1);

            // Solution 2: Recursive loop
            // Not recommend, because the human way to explain the logic is not recursive
            IFizzBuzzIterator recursiveFizzBuzz = new RecursiveFizzBuzz(fizzBuzz, stringBuilder);
            string result2 = recursiveFizzBuzz.FizzBuzzIterate(1, 100);
            Console.WriteLine(result2);

            // Solution 3: More specific, skip the checking
            IFizzBuzzIterator specificFizzBuzz = new SpecificFizzBuzz(stringBuilder);
            string result3 = specificFizzBuzz.FizzBuzzIterate(1, 100);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}