using System;
using System.Collections.Generic;
using System.Linq;

namespace aMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            while (true)
            {
                string current = Console.ReadLine();
                if (current == "stop")
                {
                    break;
                }

                if (resourses.ContainsKey(current))
                {
                    resourses[current] += int.Parse(Console.ReadLine());
                }
                else
                {
                    resourses.Add(current, 0);
                    resourses[current] += int.Parse(Console.ReadLine());
                }
                
            }

            foreach (var mine in resourses)
            {
                Console.WriteLine($"{mine.Key} -> {mine.Value}");
            }
        }

    }
}
