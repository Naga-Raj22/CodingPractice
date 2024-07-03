using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class FibonacciSeries
    {
        public void CheckFibo()
        {
            int num1 = 0, num2 = 1, num3 = 0, range;
            string str1 = string.Empty, strReverse = string.Empty;
            Console.WriteLine("FEBONACCI SERIES");
            Console.Write("Please enter range : ");
            Int32.TryParse(Console.ReadLine(),out range);
            Console.Write($"{num1} ");
            Console.Write($"{num2} ");
            while (range > 0)
            {
                num3 = num1 + num2;
                Console.Write($"{num3} ");
                num1 = num2;
                num2 = num3;
                range--;
            }
            Console.ReadKey();
        }

    }
}
