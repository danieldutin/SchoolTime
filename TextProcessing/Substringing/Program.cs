using System;
using System.Text;

namespace Substringing
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            while (second.Contains(first))
            {
                int index = second.IndexOf(first);

                second.Remove(index, first.Length);
            }

            Console.WriteLine(second);
        }
    }
}
