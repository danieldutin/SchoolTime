using System;
using System.Text;
using System.Linq;

namespace CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string cipher = GetEncryption(text);

            Console.WriteLine(cipher);
        }

       

        private static string GetEncryption(string text)
        {
            StringBuilder cipher = new StringBuilder();
            char crypto;
            for (int i = 0; i < text.Length; i++)
            {
                crypto = text[i];
                crypto++;
                crypto++;
                crypto++;

                cipher.Append(crypto);
            }

            return cipher.ToString();
        }
    }
}
