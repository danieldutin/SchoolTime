using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string command = "";
            int[] clone = new int[dnaLenght];


           int counter = 0;
            int sum = 0;
            int maxSum = 0;
            
            while (command != "Clone them!")
            {
                command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    continue;
                }
                counter++;
                int[] array = command.Split('!').Select(int.Parse).ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    clone = (int[])array.Clone();
                    
                }
                
            }



            Console.WriteLine($"Best DNA sample {counter} with sum: {maxSum}.");
            foreach (int item in clone)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
