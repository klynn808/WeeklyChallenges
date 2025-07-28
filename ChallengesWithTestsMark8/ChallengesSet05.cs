using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
            {
                throw new ArgumentException("n must not be zero", nameof(n));
            }

            return startNumber + (n - startNumber % n) % n + ((startNumber % n == 0) ? n : 0);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses == null) return;

            for (var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            if (numbers.Length < 2)
            {
                return true;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder sentenceBuilder = new StringBuilder();

            foreach (string word in words)
            {
                string trimmedWord = word.Trim();
                if (trimmedWord.Length > 0)
                {
                    sentenceBuilder.Append(trimmedWord).Append(' ');
                }
            }

            if (sentenceBuilder.Length == 0)
            {
                return string.Empty;
            }

            sentenceBuilder.Length--;
            sentenceBuilder.Append('.');

            return sentenceBuilder.ToString();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count <4)
            {
                return new double[0];
            }
            
            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
