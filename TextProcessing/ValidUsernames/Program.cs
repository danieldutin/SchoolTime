using System;
using System.Linq;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);


            foreach (var user in text)
            {
                if (IsValid(user))
                {
                    Console.WriteLine(user);
                }
            }
        }

        private static bool IsValid(string text)
        {
            return IsValidLength(text) && ContainsValidSymbols(text);
        }

        private static bool ContainsValidSymbols(string text)
        {
            foreach (char symbol in text)
            {
                if (!char.IsLetterOrDigit(symbol) && symbol != '_' && symbol != '-')
                {
                    return false;
                }
                
            }

            return true;
        }

        private static bool IsValidLength(string text)
        {
            return text.Length >= 3 && text.Length <= 16;
        }
    }
}
