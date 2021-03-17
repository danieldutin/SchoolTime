using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

           int result = GetAsciiMultiplication(text[0], text[1]);

            Console.WriteLine(result);
        }

        private static int GetAsciiMultiplication(string v1, string v2)
        {
            int minLength = Math.Min(v1.Length, v2.Length);
            int sum = 0;
            for (int i = 0; i < minLength; i++)
            {
                sum += v1[i] * v2[i];
            }

            if (v1.Length>v2.Length)
            {
                sum += SumRemaningChar(v1, minLength);
            }
            else if(v1.Length < v2.Length)
            {
                sum += SumRemaningChar(v2, minLength);
            }

            return sum;
        }

        private static int SumRemaningChar(string word, int lenght)
        {
            int sum = 0;
            for (int i = lenght; i < word.Length; i++)
            {
               sum += word[i];
            }

            return sum;
        }
    }
}
