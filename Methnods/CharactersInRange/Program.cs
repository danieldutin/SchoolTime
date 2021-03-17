using System;
using System.Collections.Generic;
using System.Linq;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            GetCharsInRange(first, second);
        }

        static void GetCharsInRange(char a, char b)
        {
            
            for (int i = a + 1; i < b; i++)
            {
               
                Console.Write(Convert.ToChar(i) + " ");
            }

            for (int i = b + 1; i < a; i++)
            {

                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}
