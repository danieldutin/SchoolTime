using System;

namespace PrintPartOfAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexStart = int.Parse(Console.ReadLine());
            int idnexEnd = int.Parse(Console.ReadLine());
            
            for (int i = indexStart; i <= idnexEnd; i++)
            {
                char current = (char)i;
                Console.Write($"{current} ");
            }
        }
    }
}
