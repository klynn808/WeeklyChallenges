using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            return words.Any(w =>
               string.Equals(w, word, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal));
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1 || (num % 2 == 0 && num != 2))
                return false;
            
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
                if (num % i == 0)
                    return false;
            
            return true;   
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            List<char> seen = new List<char>();
            List<char> duplicates = new List<char>();

            foreach (char ch in str)
            {
                if (seen.Contains(ch))
                {
                    if (!duplicates.Contains(ch))
                        duplicates.Add(ch);
                }
                else
                {
                    seen.Add(ch);
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char current = str[i];
                if (!duplicates.Contains(current))
                        return i;
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1;  i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            if (elements == null || elements.Count == 0 || n <= 0)
                return result.ToArray();

            for ( int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
