using System;

namespace ContactNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            string sumbols = Console.ReadLine();
            Console.WriteLine($"{name}{sumbols}{lastname}");
        }
    }
}
