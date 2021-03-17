using System;
using System.Collections.Generic;
using System.Linq;
namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(count);
            
            for (int i = 0; i < products.Capacity; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
            
        }

       
    }
}
