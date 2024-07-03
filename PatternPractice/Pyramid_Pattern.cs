using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pyramid_Pattern
    {
        public void Pyramid()
        {
            int intLevel, intSpace, intLength = 1;
            string charToPrint;
            try
            {
                Console.Write("Please enter the character to print : ");
                charToPrint = Console.ReadLine();
                Console.Write("Please enter pyramid level number : ");
                 intLevel = Convert.ToInt32(Console.ReadLine());
                intSpace = intLevel - 1;
                for (int i = 1; i <= intLevel; i++)
                {
                    for (int j = 1; j <= intSpace; j++)
                    {
                        // This will print the space before the pyramid
                        Console.Write(" ");
                    }
                    // With spaces and without using intLength
                    //for (int k = 1; k <= i; k++)
                    //{
                    //    Console.Write(" " + charToPrint + " ");
                    //}
                    for (int k = 1; k <= intLength; k++)
                    {
                        Console.Write(charToPrint);
                    }
                    intSpace--;
                    intLength = intLength + 2;
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
