using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int oddsSum = 0;

                foreach (int n in numbers)
                {
                    if (n % 2 != 0)
                        oddsSum += n;
                }

                return oddsSum % 2 != 0 ? true : false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i])) { containsUpper = true; }
                else if (char.IsLower(password[i])) { containsLower = true; }
                else if (char.IsDigit(password[i])) { containsNumber = true; }
            }

            if (containsUpper && containsLower && containsNumber)
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();

                for (int n = 0; n < letters.Length; n++)
                {
                    if (char.IsLetter(letters[n]))
                    {
                        letters[n] = char.ToUpper(letters[n]);
                    }
                }

                words[i] = new string(letters);
            }
        }
    }
}
