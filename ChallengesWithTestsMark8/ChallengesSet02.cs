using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CharacterIsNotALetter(char c)
        {
            return !char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers != null && numbers.Any())
            {

                double max = numbers.Max();
                double min = numbers.Min();
                return max + min;
            }
            else
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            int returnSum = 0;

            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    returnSum += num;
                }
            }

            return returnSum;
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;

            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    if ((num % 2) == 0)
                    {
                        evenSum += num;
                    }
                }
            }

            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int returnSum = 0;

            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    returnSum += num;
                }
            }

            return returnSum % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = number - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
