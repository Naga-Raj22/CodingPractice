using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LinqPractice
    {
        public void LinqPrac()
        {
            #region get even numbers from array
            // Data source
            int[] arr = new int[10] { 23, 41, 2, 38, 4, 23, 56, 43, 4, 76 };

            // Query creation
            var tempArr = from a in arr
                          where (a % 2 == 0)
                          select a;

            //var tempArrToList = (from a in arr
            //               where (a % 2 == 0)
            //               select a).ToList();

            // Query execution
            foreach (var item in tempArr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            #endregion

            #region Union, Intersect from 2 arrays

            int[] arr1 = new int[10] { 4,5,78,22,68,58,42,86,43,78};
            int[] arr2 = new int[10] { 6,4,58,86,24,67,53,35,78,54};

            //var tempArr1 = from ele in arr1.Intersect(arr2) // arr1.Union(arr2)
            //               select ele;
            Console.WriteLine("Union or intersect");

            foreach(var item in arr1)
            {
                foreach (var item2 in arr2)
                {
                    if(item2.Equals(item))
                     Console.WriteLine($"{item} is equal to {item2}"); 
                }
            }

            Console.WriteLine(" linq Union or intersect"); 
            var res = arr1.SelectMany(item1 => arr2.Where(item2 => (item1==item2)));

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            //foreach(var ele in tempArr1)
            //{
            //    Console.WriteLine(ele);
            //}

            Console.WriteLine();

            #endregion


            #region String sort based on length of words
            string[] str = new string[5] { "there", "is", "a", "Naga", "raj" };

            var tempStr = from s in str
                          orderby s.Length descending // default is asending
                          select s;

            Console.WriteLine("String length order");
            foreach (var ele in tempStr)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine();
            #endregion

            #region String sort alphabatic order of first letter of the word

            var tempStr2 = from s in str
                           orderby s.Substring(0,1)
                           select s;

            Console.WriteLine("Alphabetic order");
            foreach (var ele in tempStr2)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine();
            #endregion

            #region String sort by length alphabatic order of first letter of the word

            string[] str1 = new string[10]{"is", "of", "are", "eat", "be", "four", "Naga","cat" ,"Ramesh" , "Mahesh"};
            var tempStr3 = from s in str1
                               // orderby s.Length, s.Substring(0, 1)
                           where s.Length == 3 && s.Substring(0, 1) == "a"
                           select s;

            Console.WriteLine("Length and Alphabetic order");
            foreach (var ele in tempStr3)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine();
            #endregion



        }
    }
}
