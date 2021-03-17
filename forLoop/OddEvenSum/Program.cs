using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int oddsum = 0;
            int evensum = 0;

            for (int i = 0; i < count; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (i % 2 ==0)
                {
                    evensum += curr;
                }
                else
                {
                    oddsum += curr;
                }
            }

            if (evensum == oddsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddsum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddsum - evensum)}");
            }
        }
    }
}
