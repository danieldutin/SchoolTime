using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                bool isTopNumber = true;

                for (int k = i+1; k < arr.Length; k++)
                {
                    int rightNumber = arr[k];

                    if (rightNumber >= currentNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }
                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
//int[] arr2 = storage.Split(' ', StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse)
//    .ToArray(); 

//foreach (int item in arr2)
//{
//    Console.Write($"{arr2[item]} ");
//}
// 1 4 3 2 - test input
//string[] arrString;
//int[] arr2;
//string storage = " ";