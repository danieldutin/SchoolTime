using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           string result = IntSign(number);
            Console.WriteLine(result);
        }
        static string IntSign(int n)
        {
            string sign = null;

            if (n > 0)
            {
                sign = "positive";
                
            }
            else if (n < 0)
            {
                sign = "negative";
               
            }
            else
            {
                sign = "zero";
                
            }
            return $"The number {n} is {sign}.";
        }
    }
}
