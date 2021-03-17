using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeReversetALTERNATIVEwhitWHERE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Where(n => n >=0)
                 .Reverse()
                 .ToList();

            if (myList.Count>0)
            {
                Console.WriteLine(string.Join(" ", myList));
            }
            else
            {
                Console.WriteLine("empty");
            }


        }
    }
}
