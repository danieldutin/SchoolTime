using System;
using System.Linq;
namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();


            Random rdm = new Random();


            for (int i = 0; i < words.Length; i++)
            {
                int position = rdm.Next(words.Length); // maximum length is never going to be reached.

                string word = words[i];
                words[i] = words[position];
                words[position] = word; 
            }

            Console.Write(string.Join("\n", words));
        }
    }
}
