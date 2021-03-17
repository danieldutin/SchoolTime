using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    result = i * j;
                    Console.WriteLine($"{i} * {j} = {result}");
                }
            }
        }
    }
}
