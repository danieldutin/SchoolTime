using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] < 0)
                {
                    int current = myList[i];
                    myList.Remove(current);
                    i = i - 1;
                }
                
            }

            myList.Reverse();

            if (myList.Count<1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var item in myList)
                {
                    Console.Write($"{item} ");
                }
            }
            
            
        }
    }
}
