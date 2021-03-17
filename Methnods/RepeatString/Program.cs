using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string random = Console.ReadLine();
            int repetitionAmount = int.Parse(Console.ReadLine());

            Console.WriteLine(GetRepeat(random, repetitionAmount));
            
        }
        static string GetRepeat(string any, int rep)
        {
            string newString ="";
            for (int i = 0; i < rep; i++)
            {
                newString = newString + any;
            }
            return newString;
        }
    }
}
