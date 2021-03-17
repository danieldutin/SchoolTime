using System;
using System.Linq;
namespace WordsFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string[] filtered = words.Where(word => word.Length % 2 == 0).ToArray();

            foreach (var item in filtered)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}
