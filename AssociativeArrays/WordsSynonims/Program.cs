﻿using System;
using System.Collections.Generic;

namespace WordsSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (synonims.ContainsKey(word))
                {
                    synonims[word].Add(synonim);
                }
                else
                {
                    synonims.Add(word, new List<string> { synonim });
                }
            }

            foreach (var word in synonims)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
