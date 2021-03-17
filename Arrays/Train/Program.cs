using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in train)
            {
                Console.Write($"{item} ");
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
