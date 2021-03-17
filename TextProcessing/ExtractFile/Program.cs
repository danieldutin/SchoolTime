using System;
using System.Text;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\');

            string[] fileWhithExt = path[path.Length-1].Split('.');

            Console.WriteLine($"File name: {fileWhithExt[0]}");
            Console.WriteLine($"File extension: {fileWhithExt[1]}");
        }
    }
}
