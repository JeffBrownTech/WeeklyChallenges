using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Sum(n => n % 2 == 0 ? n : -n);
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<string> { str1, str2, str3, str4 };
            return stringList.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var intList = new List<int> { number1, number2, number3, number4 };
            return intList.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(x => x == null) > objs.Length * 0.5;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;

            return numbers.Where(x => x % 2 == 0).DefaultIfEmpty(0).Average();
        }

        public int Factorial(int number)
        {
            // Notes for myself:
            // Enumerable.Range create a range of number (e.g. [1, 2, 3, etc])
            // Aggregate is an accumulator function or a way to combine all values
            // Syntax:  .Aggregate(<seedValue>, (<accumulator>, <current>) => <operation>)
            // Accumulator holds the answer of the operation as it moves through the sequence
            // Current holds the next item in the list
            // Seed value starts the result at 1 and works when the sequence is empty

            return Enumerable.Range(1, number).Aggregate(1, (a, b) => a * b);
        }
    }
}
