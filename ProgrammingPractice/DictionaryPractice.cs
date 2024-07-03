using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class DictionaryPractice
    {
        public void CountRepeatedNumbers()
        {
            int[] arr = { 10, 5, 10, 2, 5, 4, 5 };
            var dict = new Dictionary<int, int>();
            foreach (var value in arr)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} = {1} time(s)", pair.Key, pair.Value);
            }
            var sort1 = new SortedList();
            //sort1.Add(1, "naga");
            //sort1.Add(2, "raj");
            //sort1.Add(3, "bhaagi");
            sort1.Add("Bag", "Lucky");
            sort1.Add("Ant", 2);
            foreach (var ele in sort1)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine(sort1.ContainsValue(2));
            Console.ReadKey();
        }
    }
    interface I1
    {
        void F1();
    }
    interface I2
    {
        void F1();
    }
    class C3 : I1, I2
    {
        public void F1()
        {
            Console.WriteLine("This is Overriding the F1() function of Both I1 and I2 Interfaces");

        }
        void I1.F1()
        {
            Console.WriteLine("This is Overriding F1() function of I1 interface");
        }
        void I2.F1()
        {
            Console.WriteLine("This is Overriding F1() function of I2 interface");
        }
    }
}
