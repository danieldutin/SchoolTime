using System;
using System.Text.RegularExpressions;
namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                string any = Console.ReadLine();
                if (any=="end")
                {
                    break;
                }
                string reversed = "";
                for (int i = any.Length-1; i >=0; i--)
                {
                    reversed += any[i];
                }

                Console.WriteLine($"{any} = {reversed}");
            }

        }
    }
}
