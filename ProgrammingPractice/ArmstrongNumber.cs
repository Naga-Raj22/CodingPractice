using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class ArmstrongNumber
    {
        public void CheckNumber() 
        {
            long num,inputNum, total = 0, rem, digits;
            try
            {
                Console.WriteLine("CHECKING ARMSTRONG NUMBER");
                Console.Write("Please enter number : ");
                num = Convert.ToInt64(Console.ReadLine());
                inputNum = num;
                CommonFunctions common = new CommonFunctions();
                digits = common.NumberOfDigits(num);
                while (num > 0)
                {
                    rem = num % 10;
                    // rem = rem * digits; Use this or below Maths function
                    total = total + Convert.ToInt32(Math.Pow(rem,digits));
                    num = num / 10;
                }
                if (total == inputNum)
                    Console.WriteLine("Given number {0} is Armstrong number", inputNum);
                else
                    Console.WriteLine("Given number {0} is not Armstrong number", inputNum);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
