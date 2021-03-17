using System;
using System.Collections.Generic;
using System.Linq;

namespace TestField
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Write a program that counts the repetitions of letters a, b and c in a given string.
            //
            // Example:
            // Input 1:
            // alphabetical
            // Output 1:
            // a => 3 b => 1 c => 1

            string letters = "alphabetical";

            int countA = letters.Count(x=> x == 'a');
            int countB = letters.Count(x => x == 'b');
            int countC = letters.Count(x => x == 'c');

            Console.WriteLine($"a => {countA} b => {countB} c => {countC}");

        }
    }
}
