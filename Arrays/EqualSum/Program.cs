using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            bool exist = false;

            for (int i = 0; i  < arr.Length; i ++)
            {
                
                int sumLeft = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += arr[k];
                }
                int sumRight = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }
                int current = arr[i];
                //sumLeft == current && sumRight == current && 

                if (sumRight==sumLeft)
                {
                    Console.WriteLine(i);
                    exist = true;
                    break;
                }
                
            }
            if (!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
