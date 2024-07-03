using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Diamond_Parttern
    {
        public void DiamondPattern()
        {
            int intLevel, intSpace, intLength = 1;
            string charToPrint;
            try
            {
                //Console.Write("Please enter the character to print : ");
                //charToPrint = Console.ReadLine();
                //Console.Write("Please enter pyramid level number : ");
                //intLevel = Convert.ToInt32(Console.ReadLine());
                charToPrint = "$";
                intLevel = 10;
                intSpace = intLevel - 1;
                for (int i = 1; i <= intLevel; i++)
                {
                    for (int j = 1; j <= intSpace; j++)
                    {
                        // This will print the space before the pyramid
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= intLength; k++)
                    {
                        Console.Write(charToPrint);
                    }
                    intSpace--;
                    intLength = intLength + 2;
                    Console.WriteLine();
                }
                intLength = intLength - 4;
                intSpace = intSpace+2;
                for (int i = intLevel; i >=1 ; i--)
                {
                    for (int j = 1; j <= intSpace; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= intLength; k++)
                    {
                        Console.Write(charToPrint);
                    }
                    intSpace++;
                    intLength = intLength - 2;
                    Console.WriteLine();
                }

                // With spaces and without using intLength

                charToPrint = "$";
                intLevel = 10;
                intSpace = intLevel - 1;
                for (int i = 1; i <= intLevel; i++)
                {
                    for (int j = 1; j <= intSpace; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(" " + charToPrint);
                    }
                    intSpace--;
                    Console.WriteLine();
                }
                intLength = intLevel + 2;
                intSpace = intSpace + 2;
                for (int i = intLevel - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= intSpace; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(" " + charToPrint);
                    }
                    intSpace++;
                    intLength = intLength - 2;
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
