using System;
using System.Globalization;
using System.Linq;
using System.Security.Principal;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) =>
        numbers.Sum(n => n % 2 == 0 ? n : -n);

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4) =>
            new[] { str1, str2, str3, str4 }.Min(s => s.Length);


        public int GetSmallestNumber(int number1, int number2, int number3, int number4) =>
            new[] { number1, number2, number3, number4 }.Min();

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public Func<int, int, int, bool> CouldFormTriangle = (side1, side2, side3) =>
            (side1 + side2 > side3) &&
            (side1 + side3 > side2) &&
            (side3 + side2 > side1);

        public Func<string, bool> IsStringANumber = input =>
            double.TryParse(input, out _);

        public bool MajorityOfElementsInArrayAreNull(object[] objs) =>
            objs?.Length > 0 && objs.Count(e => e == null) > objs.Length / 2;

        public double AverageEvens(int[] numbers) =>
            numbers?.Where(e => e % 2 == 0).DefaultIfEmpty().Average() ?? 0;

        public int Factorial(int number) =>
            number < 0 ? 0 
            : Enumerable.Range(1, number)
                        .Aggregate(1, (acc, n) => acc * n);
    }
}
