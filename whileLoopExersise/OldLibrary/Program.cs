using System;

namespace OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int count = 0;
            bool bookFound = false;
            string newSearch = Console.ReadLine();
            while (newSearch != "No More Books")
            {
                if (favoriteBook == newSearch)
                {
                    bookFound = true;
                    break;
                }
                count++;
                newSearch = Console.ReadLine();
            }
            if (bookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
