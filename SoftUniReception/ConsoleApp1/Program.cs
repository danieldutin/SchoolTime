using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            GetTopFive(numbers);
        }

        static void GetTopFive(List<int> myList)
        {
            int average = (int)myList.Average();
            myList.RemoveAll(a => a <= average);
            myList.Sort();
            if (myList.Count<=0)
            {
                Console.WriteLine("No");
            }
            else
            {
                int count = 0;
                for (int i = myList.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{myList[i]} ");
                    count++;
                    if (count >= 5)
                    {
                        break;
                    }
                }
            }
        }
    }
}
