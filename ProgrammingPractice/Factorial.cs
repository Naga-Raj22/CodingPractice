using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class Factorial
    {
        public void CheckFactorial() 
        {
            int num, num2 = 1;
            Console.WriteLine("FIND FACTORIAL NUMBER");
            Console.Write("Please enter number : ");
            Int32.TryParse(Console.ReadLine(), out num);
            for (int i = 1; i <= num; i++)
            {
                num2 = num2 * i;
            }
            Console.WriteLine($"Factorial for the given number {num} is {num2}");
        }
    }
}
