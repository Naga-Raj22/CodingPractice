using System;

namespace OOPSPractice
{
    
        sealed class NewClass1
    {
        int a = 0;
        public NewClass1() {
            a = 20;
        }
        public void sealedmethod()
        {
            Console.WriteLine("this is sealed method {0}", a);
        }

        }
    public class NewClass2
    {
    }

    class Program
    {


        static string PlusMethod(string a, int b)
        {
            int[] arr1 = new int[] { 7, 5, 4, 6, 8, 2, 1, 10, 9, 3 };
            int target = 12;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] + arr1[j] == target)
                    {
                        Console.WriteLine("{0} , {1}", arr1[i], arr1[j]);
                    }
                }
                Console.WriteLine();
            }
            return "1";
        }

        static string PlusMethod(int a, string b)
        {
            int[] arr1 = new int[] { 7, 5, 4, 6, 8, 2, 1, 10, 9, 3 };
            int findNum = 8;

            foreach (int x in arr1)
            {
                if (x == findNum)
                {
                    Console.WriteLine(" found the number " + x);
                }
            }
            return "2";
        }

        static void Main(string[] args)
        {
            string myNum1 = PlusMethod("2", 5);
            string myNum2 = PlusMethod(2, "2");
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

           NewClass1 newClass1 = new NewClass1();
            newClass1.sealedmethod();
        }


    }
}
