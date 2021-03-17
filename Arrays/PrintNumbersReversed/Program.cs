using System;

namespace PrintNumbersReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = array.Length-1; i > -1; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
