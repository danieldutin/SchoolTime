using System;
using System.Linq;
namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string lowUp = Console.ReadLine();
            if (lowUp.Any(char.IsUpper))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
            
            
        }
    }
}
