using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(PasswordContainsUpperLowerAndNumber("correcthorsebatterystaple"));
        }
        public static  bool PasswordContainsUpperLowerAndNumber(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 'a' || password[i] <= 'z') && (password[i] >= 'A' || password[i] <= 'Z') && (password[i] >= '0' || password[i] <= '9'))
                {
                    return true;
                    
                }
                Console.WriteLine(password[i]);
            }
            return false;
        }
    }
}
