using System;

namespace rounding_
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerOne = double.Parse(Console.ReadLine());
            //закръгляне на по-горно число
            Console.WriteLine(Math.Ceiling(numerOne));
            //закръгляне на по-долно число
            Console.WriteLine(Math.Floor(numerOne));
            Console.WriteLine($"{Math.Floor(numerOne):f2}");
            Console.WriteLine($"{Math.Ceiling(numerOne):f2}");
            //закръгляне до най-близкото число ако е < n.5 или > n.5 
            Console.WriteLine($"{Math.Round(numerOne):f2}");

            // обръща в противоположна стойност - от минус към плюс или обратно
            Console.WriteLine(Math.Abs(-45));
        }
    }
}
