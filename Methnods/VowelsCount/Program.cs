using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            Console.WriteLine(GetVowelsCount(word));

        }
        static int GetVowelsCount(string a)
        {
            char letter='0';
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                letter = a[i];
                if (a[i].ToString() == "a"||
                    a[i].ToString() == "o" ||
                    a[i].ToString() == "e" ||
                    a[i].ToString() == "i" ||
                    a[i].ToString() == "u" ||
                    a[i].ToString() == "y")
                {
                    sum++;
                }
            }
            
            return sum;
        }
    }
}
