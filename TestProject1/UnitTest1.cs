using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using NUnit.Framework;
using System.Text;

namespace TestProject1
{
    public class Tests
    {
        const string result = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
Fizz
22
23
Fizz
Buzz
26
Fizz
28
29
FizzBuzz
31
32
Fizz
34
Buzz
Fizz
37
38
Fizz
Buzz
41
Fizz
43
44
FizzBuzz
46
47
Fizz
49
Buzz
Fizz
52
53
Fizz
Buzz
56
Fizz
58
59
FizzBuzz
61
62
Fizz
64
Buzz
Fizz
67
68
Fizz
Buzz
71
Fizz
73
74
FizzBuzz
76
77
Fizz
79
Buzz
Fizz
82
83
Fizz
Buzz
86
Fizz
88
89
FizzBuzz
91
92
Fizz
94
Buzz
Fizz
97
98
Fizz
Buzz
";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HardCodedIterativeTest()
        {
            var stringBuilder = new StringBuilder();
            IFizzBuzz fizzBuzz = new FizzBuzzService();
            IFizzBuzzIterator fizzBuzzIterator = new IterativeFizzBuzz(fizzBuzz, stringBuilder);
            Assert.AreEqual(result, fizzBuzzIterator.FizzBuzzIterate(1, 100));
        }

        [Test]
        public void HardCodedRecursiveTest()
        {
            var stringBuilder = new StringBuilder();
            IFizzBuzz fizzBuzz = new FizzBuzzService();
            IFizzBuzzIterator fizzBuzzIterator = new RecursiveFizzBuzz(fizzBuzz, stringBuilder);
            Assert.AreEqual(result, fizzBuzzIterator.FizzBuzzIterate(1, 100));
        }

        [Test]
        public void HardCodedSpecificTest()
        {
            var stringBuilder = new StringBuilder();
            IFizzBuzzIterator fizzBuzzIterator = new SpecificFizzBuzz(stringBuilder);
            Assert.AreEqual(result, fizzBuzzIterator.FizzBuzzIterate(1, 100));
        }

        [Test]
        [TestCase(1, 100)]
        [TestCase(10, 100)]
        public void LogicIterativeTest(int startValue, int endValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringBuilder.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    stringBuilder.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    stringBuilder.AppendLine("Buzz");
                }
                else
                {
                    stringBuilder.AppendLine(i.ToString());
                }
            }
            string expected = stringBuilder.ToString();
            stringBuilder.Clear();
            IFizzBuzz fizzBuzz = new FizzBuzzService();
            IFizzBuzzIterator fizzBuzzIterator = new IterativeFizzBuzz(fizzBuzz, stringBuilder);
            Assert.AreEqual(expected, fizzBuzzIterator.FizzBuzzIterate(startValue, endValue));
        }

        [Test]
        [TestCase(1, 100)]
        [TestCase(10, 100)]
        public void LogicRecursiveTest(int startValue, int endValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringBuilder.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    stringBuilder.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    stringBuilder.AppendLine("Buzz");
                }
                else
                {
                    stringBuilder.AppendLine(i.ToString());
                }
            }
            string expected = stringBuilder.ToString();
            stringBuilder.Clear();
            IFizzBuzz fizzBuzz = new FizzBuzzService();
            IFizzBuzzIterator fizzBuzzIterator = new RecursiveFizzBuzz(fizzBuzz, stringBuilder);
            Assert.AreEqual(expected, fizzBuzzIterator.FizzBuzzIterate(startValue, endValue));
        }

        [Test]
        [TestCase(1, 100)]
        [TestCase(10, 100)]
        public void LogicSpecificTest(int startValue, int endValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = startValue; i <= endValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringBuilder.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    stringBuilder.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    stringBuilder.AppendLine("Buzz");
                }
                else
                {
                    stringBuilder.AppendLine(i.ToString());
                }
            }
            string expected = stringBuilder.ToString();
            stringBuilder.Clear();
            IFizzBuzzIterator fizzBuzzIterator = new SpecificFizzBuzz(stringBuilder);
            Assert.AreEqual(expected, fizzBuzzIterator.FizzBuzzIterate(startValue, endValue));
        }
    }
}