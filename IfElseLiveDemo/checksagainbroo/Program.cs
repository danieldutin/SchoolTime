using System;

namespace checksagainbroo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerOne = int.Parse(Console.ReadLine());

            if (numerOne % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}       