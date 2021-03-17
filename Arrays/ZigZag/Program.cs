using System;
using System.Linq;
namespace ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] first = new int[n];
            int[] second = new int[n];
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                var newString = Console.ReadLine().Split(" ");
                if (counter%2==0)
                {
                    first[i] = int.Parse(newString[1]);
                    second[i] = int.Parse(newString[0]);
                   
                }
                else
                {
                    first[i] = int.Parse(newString[0]);
                    second[i] = int.Parse(newString[1]);
                }
                
                counter++;

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{first[i]} ");
            }
               
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{second[i]} ");
            }

        }
    }
}
