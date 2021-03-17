using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double division = GetFactDivisiion(n, m);

            Console.WriteLine($"{division:f2}") ;
        }

        private static double GetFactDivisiion(int n, int m)
        {
           return  GetFactorialSum(n) / GetFactorialSum(m) ;

        }

        static int GetFactorialSum (int a)
        {
            int fact = a;

            for (int i = a - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}
