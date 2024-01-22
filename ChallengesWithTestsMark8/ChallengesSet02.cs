using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(c) ? true : false;
        //{
        //return char.IsLetter(c);
        //string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //for (int i = 0; i < alphabet.Length; i++)
        //{
        //    if (alphabet[i] == c)
        //    {
        //        return true;
        //    }
        //}
        //return false;
        //}

        public bool CountOfElementsIsEven(string[] vals)
            => (vals.Length % 2 == 0) ? true : false;

        public bool IsNumberEven(int number)
            => (number % 2 == 0) ? true : false;


        public bool IsNumberOdd(int num)
            => (num % 2 == 0) ? false : true;

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers == null || !numbers.Any()) ? 0 : (numbers.Max() + numbers.Min());
        }
            

        public int GetLengthOfShortestString(string str1, string str2)
        => ((str1.Length - str2.Length) > 0) ? str2.Length : str1.Length;

        public int Sum(int[] numbers) => (numbers != null) ? numbers.Sum() : 0;
        

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
        public bool IsSumOdd(List<int> numbers)
            => (numbers != null) && (numbers.Sum() % 2 != 0); 
       

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {  
                return 0;             
            }

            long count = 0;
            
            for (long i = 1; i < number; i += 2)
            {
                 count++;              
            }
            return count;
        }
    }
}
