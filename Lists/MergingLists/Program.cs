using System;
using System.Collections.Generic;
using System.Linq;


namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newlist = new List<int>(first.Count + second.Count);

            int limit = Math.Min(first.Count, second.Count);

            for (int i = 0; i < limit; i++)
            {
                newlist.Add(first[i]);
                newlist.Add(second[i]);
            }

            if (first.Count != second.Count)
            {
                if (first.Count > second.Count)
                {
                  newlist.AddRange(GetBigger(first, second));
                }
                else
                {
                    newlist.AddRange(GetBigger(second, first));
                }
            }

            Console.WriteLine(string.Join(" ", newlist));
        }

        static List<int> GetBigger(List<int> longList, List<int> shortList)
        {
            if (longList.Count <=shortList.Count)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();

            for (int i = shortList.Count; i < longList.Count; i++)
            {
                result.Add(longList[i]);
            }

            return result;
        }
    }
}
