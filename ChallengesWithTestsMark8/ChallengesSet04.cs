using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
                if(num % 2 != 0)
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           string[] strings = {str1, str2, str3, str4};
            var shortString = strings.OrderBy(num => num.Length).FirstOrDefault();
            if(shortString != null)
            {
                return shortString.Length;
            }
            return 0;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var list = new List<int>() { sideLength1, sideLength2, sideLength3 };
            for (int i = 0; i < list.Count; i++)
            {
                int sumOfOtherSides = list.Sum() - list[i];
                if (sumOfOtherSides <= list[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double num);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if(objs == null || objs.Length == 0)
            {
                return false;
            }
            int nullCount = objs.Count(objs => objs == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var evens = numbers.Where(num => num % 2 == 0);
            if(evens.Any() == true)
            {
                return evens.Average();
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
