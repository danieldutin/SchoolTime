using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine().ToLower();
            string first = Console.ReadLine();
            string second = Console.ReadLine();



            if (valueType == "int")
            {
                Console.WriteLine(IntChecker(first, second));
            }
            else if (valueType == "string")
            {
                Console.WriteLine(StringChecker(first, second));
            }
            else
            {
                Console.WriteLine(CharChecker(first, second));
            }
        }
        static int IntChecker(string a, string b)
        {

            int oneInt = int.Parse(a);
            int twoInt = int.Parse(b);
            int isBigger;
            if (oneInt < twoInt)
            {
                return isBigger = twoInt;
            }
            else
            {
                return isBigger = oneInt;
            }


        }

        static string StringChecker(string x, string y)
        {
            string oneString = x;
            string twoString = y;
            string isBigger;

            int sumOne = 0;
            int sumTWo = 0;

            for (int i = 0; i < oneString.Length; i++)
            {
                char current = oneString[i];
                sumOne += current;
            }

            for (int i = 0; i < twoString.Length; i++)
            {
                char current = twoString[i];
                sumTWo += current;
            }

            if (sumTWo > sumOne)
            {
                return isBigger = twoString;
            }
            else
            {
                return isBigger = oneString;
            }
        }

        static char CharChecker(string q, string z)
        {
            char oneChar = q[0];
            char twoChar = z[0];
            char isBigger;
            if (oneChar < twoChar)
            {
                return isBigger = twoChar;
            }
            else
            {
                return isBigger = oneChar;
            }
        }
    }


}
