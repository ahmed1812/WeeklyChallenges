using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            for (int i=0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return false ;
            }
            for (int i=0; i<numbers.Count(); i++)
            {
                sum += numbers.ElementAt(i);
            }
            if (sum % 2 != 0)
            {
                return true ;
            }
            return false ;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            for (int i=0; i<password.Length; i++)
            {
                if ((password[i] >= 'a' && password[i] <= 'z') && (password[i] >= 'A' && password[i] <= 'Z') && (password[i] >= '0' && password[i] <= '9'))
                {
                    return true;
                }
            }
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
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word.ToUpper());
            }
        }
    }
}
