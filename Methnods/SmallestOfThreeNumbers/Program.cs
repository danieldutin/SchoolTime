using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallest(first, second, third));
        }
        static int GetSmallest(int a, int b, int c)
        {
            int isSmallest = int.MaxValue;
            if (a<isSmallest)
            {
                isSmallest = a;
            }
            if (c<isSmallest)
            {
                isSmallest = c;
            }
            if (b<isSmallest)
            {
                isSmallest = b;
            }
            
            return isSmallest;
        }
    }
}
