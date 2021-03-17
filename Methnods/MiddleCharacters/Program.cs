using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                Console.WriteLine(GetMiddleCharIfOdd(input));
            }
            else
            {
                Console.WriteLine(GetMiddleCharIfEven(input));
            }

        }

        static string GetMiddleCharIfOdd(string input)
        {
            char currentOne = input[(input.Length -1) / 2]; ;
            char currentTwo = input[input.Length/ 2]; ;
            string middle = currentOne.ToString() + currentTwo.ToString();

           return  middle;
        }

        static string GetMiddleCharIfEven(string input)
        {
            char current = input[(input.Length/2)];
            string middle = current.ToString();

            return middle;
        }
    }
}
