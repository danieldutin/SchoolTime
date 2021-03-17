using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input="";
            while (input != "end")
            {
                input = Console.ReadLine().ToLower();
                bool palindrome = GetPalindromeTF(input);
                if (input != "end")
                {
                    if (palindrome)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
            
        }

        static bool GetPalindromeTF(string n)
        {
            char[] real = n.ToCharArray();
            char[] reversed = real.Reverse().ToArray();
            string newstring = "";
            for (int i = 0; i < reversed.Length; i++)
            {
                 newstring = newstring + reversed[i].ToString();
            }
            
            bool palindrome;
            if (n == newstring)
            {
                palindrome = true;
            }
            else
            {
                palindrome = false;
            }

            return palindrome;
        }
    }
}
