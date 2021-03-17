using System;
using System.Linq; // system linq is giving us declarative way of writing code

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()//getting the input
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)//Split sthe string by "space" and removing the epties
                 .Select(int.Parse)// then select all items in the collection
                 .ToArray();//and add it to the array
        }
    }
}
