using System;

namespace ifElseChecksbroo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            //Math functions are usefull for simple checks broo!
            int isBigger = Math.Max(numberTwo, numerOne);
            Console.WriteLine(isBigger);

            
        }
    }
}
