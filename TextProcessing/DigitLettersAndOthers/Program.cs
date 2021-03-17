using System;
using System.Linq;
using System.Text;

namespace DigitLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (char sumbol in text)
            {
                if (sumbol <= 57 && sumbol > 47)
                {
                    digits.Append(sumbol);
                }
                else if ((sumbol > 64 && sumbol < 91) || (sumbol > 96 && sumbol < 123))
                {
                    letters.Append(sumbol);
                }
                else
                {
                    symbols.Append(sumbol);
                }
            }

            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(symbols.ToString());
        }
    }
}
