using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;
            for (int num = 0; num < number.Length; num++)
            {

                int digit = int.Parse(number[num].ToString());
                sum += digit;
                 
            }
            Console.WriteLine(sum);

        }
    }
}
