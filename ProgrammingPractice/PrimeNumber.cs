using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class PrimeNumber
    {
        public void CheckPrime()
        {
            int num = 5, isPrime = 0;
            Console.WriteLine("CHECKING PRIME NUMBER");
            Console.Write("Please enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = 1;
                    break;
                }
            }
            if (isPrime == 1)
                Console.WriteLine("Not Prime Number");
            else
                Console.WriteLine("Prime Number");
        }
    }
}
