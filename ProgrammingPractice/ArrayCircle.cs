using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class ArrayCircle
    {
        public void CreateCircle() 
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr1.Length; i++)
            {
                int k = i;
                for (int j = 0; j < arr1.Length; j++)
                {
                    Console.Write(arr1[k] + " ");
                    k++;
                    if (k == arr1.Length)
                    {
                        k = 0;
                    }
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
        
    }
}
