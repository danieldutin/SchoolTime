using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string inputPassword = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != inputPassword)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
