using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = GetSum(a, b);

            int result = GetSubs(sum,c);
            Console.WriteLine(result);
        }

        static int GetSum(int a, int b)
        {
            return a + b;
        }
        static int GetSubs(int sum, int division)
        {
            return sum - division;
        }
    }
}
