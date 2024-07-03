using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class StringReverse
    {
        public void Reverse()
        {
            int Length = 0;
            string str1 = string.Empty, strReverse = string.Empty;
            Console.WriteLine("SRING REVERSE");
            Console.Write("Please enter any word : ");
            str1 = Console.ReadLine();

            //both logics work

            //Length = str1.Length-1;
            //for (int i = 0; i < str1.Length; i++)
            //{           
            //    strReverse = strReverse + str1.Substring(Length, 1);
            //    Length--;
            //}

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                strReverse = strReverse + str1[i];
            }

            Console.WriteLine($"{str1}'s reverse is {strReverse}");

            if (strReverse.ToLower().Equals(str1.ToLower()))
                Console.WriteLine($"{str1} is Palindrome");
            else
                Console.WriteLine($"{str1} is not Palindrome");
        }
    }
}
