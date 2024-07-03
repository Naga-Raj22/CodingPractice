using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class Palindrome
    {
        public void CheckPalindrome()
        {
            long num,inputNum, reverse=0, rem;
            try
            {
                Console.WriteLine("CHECKING PALINDROME NUMBER");
                Console.Write("Please enter number : ");
                num = Convert.ToInt64(Console.ReadLine());
                inputNum = num;
                while(num > 0)
                {
                    rem = num % 10;
                    reverse = reverse * 10 + rem; 
                    num = num / 10;
                }
                if(inputNum == reverse)
                    Console.WriteLine("Given number {0} is palindrome number", inputNum);
                else
                        Console.WriteLine("Given number {0} is not palindrome number", inputNum);
                    Console.ReadKey();                
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
