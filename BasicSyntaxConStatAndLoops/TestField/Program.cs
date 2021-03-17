using System;
using System.Globalization;

namespace TestField
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(n.DayOfWeek);
        }
    }
}
