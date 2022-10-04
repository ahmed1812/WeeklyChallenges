using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < lowercaseAlphabet.Length; i++)
            {
                if (lowercaseAlphabet[i].Equals(c))
                    return true;
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           return vals.Length %2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max = numbers.ElementAt(0);//num[0]
            double min = numbers.ElementAt(0);
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
           foreach (var number in numbers)
           {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
           }
            return max+min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }foreach (int n in numbers)
            {
                if (n%2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            bool flag = false;
            int sum = 0;
            if (numbers == null)
            {
                return flag;
            }
            foreach (int n in numbers)
            {
                sum += n;
            }
           if (sum % 2 != 0)
                flag = true;
           return flag;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
           if (number < 1)
            {
                return 0;
            }
            
            for (int i = 0; i < number; i++)
            {
                if ((i % 2) != 0)
                    count++;
            }
            return count;
        }
    }
}
