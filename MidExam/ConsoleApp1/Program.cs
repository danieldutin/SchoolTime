using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]  valuableItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            if (entryPoint == valuableItems.Length)
            {
                entryPoint -= 1;
            }
            string value = Console.ReadLine();
            if (value == "cheap")
            {
                GetCheap(valuableItems, entryPoint, sumLeft, sumRight);
            }
            else
            {
                GetExpensive(valuableItems, entryPoint, sumLeft, sumRight);
            }

        }

        static void GetCheap(int[] myList, int number, int sumL, int sumR)
        {
            
            for (int i = 0; i < number; i++)
            {
                if (myList[i] < myList[number])
                {
                    sumL += myList[i];
                }
            }
            for (int i = number + 1; i < myList.Length; i++)
            {
                if (myList[i] < myList[number])
                {
                    sumR += myList[i];
                }
            }

            if (sumR > sumL)
            {
                Console.WriteLine($"Right - {sumR}");
            }
            else
            {
                Console.WriteLine($"Left - {sumL}");
            }
        }
        static void GetExpensive(int[] myList, int number, int sumL, int sumR)
        {
            for (int i = 0; i < number; i++)
            {
                if (myList[i] >= myList[number])
                {
                    sumL += myList[i];
                }
            }
            for (int i = number + 1; i < myList.Length; i++)
            {
                if (myList[i] >= myList[number])
                {
                    sumR += myList[i];
                }
            }

            if (sumR > sumL)
            {
                Console.WriteLine($"Right - {sumR}");
            }
            else
            {
                Console.WriteLine($"Left - {sumL}");
            }
        }
    }
}
