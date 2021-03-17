using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var text in input)
            {
                string inner = text;

                foreach (var item in inner)
                {
                    if (counts.ContainsKey(item))
                    {
                        counts[item]++;
                    }
                    else
                    {
                        counts.Add(item, 1);
                    }
                }
                
            }

            foreach (var character in counts)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
