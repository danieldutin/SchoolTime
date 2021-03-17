using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int newNumber =0;
            int globalFactSum = 0;
            char digit;

            for (int i = 0; i < number.Length; i++)
            {
                digit = number[i];
                newNumber = int.Parse(digit.ToString());
                int fact = 1;
                for (int j = 1; j <= newNumber; j++)
                {
                    fact = fact * j;
                }
                globalFactSum += fact;
                
               
                
            }



            if (globalFactSum == int.Parse(number.ToString()))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
