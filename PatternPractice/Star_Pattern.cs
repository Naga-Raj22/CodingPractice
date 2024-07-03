class Star_Pattern
{
    public void PrintStarPattern()
    {
        int num;
        string charToPrint;
        Console.Write("Please enter the character to print : ");
        charToPrint = Console.ReadLine().ToString();
        Console.Write("Please enter num of iteration : ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(" "+charToPrint+" ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}



