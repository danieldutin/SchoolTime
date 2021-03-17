using System;
using System.Linq;
namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', arr.Reverse()));//print on the console, the join string from the collectione"arr" using interval as separator

            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
        }
    }
}
