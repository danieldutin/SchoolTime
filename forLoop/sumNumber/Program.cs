using System;

namespace sumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumLenght = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < sumLenght; i++)
            {
                
                int number = int.Parse(Console.ReadLine());
                result  += number;
                
            }
            Console.WriteLine(result);
        }
    }
}
