using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            decimal curent;
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                curent = decimal.Parse(Console.ReadLine());
                sum += curent;
            }
            Console.WriteLine(sum);
        }
    }
}
