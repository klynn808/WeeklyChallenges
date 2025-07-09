using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{   
    public delegate bool IsSumOfOddsOddDelegate(IEnumerable<int> numbers);
    public class ChallengesSet03
    {
        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            var normalizedWord = new string(word
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            return normalizedWord.SequenceEqual(normalizedWord.Reverse());
        }

        public bool ArrayContainsAFalse(bool[] vals)
        => Array.Exists(vals, element => element == false);

        public Func<IEnumerable<int>, bool> IsSumOfOddsOdd =>
            numbers => numbers != null ? numbers.Where(num => num % 2 != 0).Sum() % 2 != 0 : false;
        //int sumOfOdds = numbers.Where(num => num % 2 != 0).Sum();
        //return sumOfOdds % 2 != 0; 

        // Using the custom delegate type
        public IsSumOfOddsOddDelegate IsSumOfOddsOddMethod =>
               numbers => numbers != null ? numbers.Where(num => num % 2 != 0).Sum() % 2 != 0 : false;

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password != null)
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(c))
                    {
                        hasLower = true;
                    }
                    else if (char.IsDigit(c))
                    { 
                        hasDigit = true; 
                    }
                }
                return hasUpper && hasLower && hasDigit;
            } 
            else 
            { 
                return false; 
            }
        }
        public char GetFirstLetterOfString(string val)
            => val[0];
        //with LINQ
        //=> val.First();

        public char GetLastLetterOfString(string val)
            => val[val.Length - 1];
        // with LINQ
        // => val.Last();

        public decimal Divide(decimal dividend, decimal divisor)
          => (divisor != 0) ? dividend / divisor : 0;

        public int LastMinusFirst(int[] nums)
            => nums[nums.Length - 1] - nums[0];

        public int[] GetOddsBelow100()
            => Enumerable.Range(1, 99).Where(num => num % 2 != 0).ToArray();

        public void ChangeAllElementsToUppercase(string[] words)
            => words.Select((word, index) => (index, word?.ToUpper())).ToList()
                    .ForEach(tuple => words[tuple.index] = tuple.Item2);
    }
}
