using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberIteration
    {
        public static void NumberPattern()
        {
            int intNumber,num=1;
            Console.Write("Please enter number : ");
            intNumber = Convert.ToInt32(Console.ReadLine());           
			try
			{
                for (int i = 1; i <= intNumber; i++)
                {
                    for(int j=1; j<=i; j++)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
