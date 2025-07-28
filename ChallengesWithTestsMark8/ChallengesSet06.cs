using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (string.IsNullOrEmpty(word) || words == null)
            {
                return false;
            }

            return words.Any(w =>
                w != null &&
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
            int index = -1;
            bool uniIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniIndex = false;
                    }
                }

                if (uniIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            if (elements == null || elements.Count == 0 || n <= 0)
                return result.ToArray();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
