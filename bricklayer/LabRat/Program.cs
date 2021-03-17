using System;
using System.Collections.Generic;

namespace LabRat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[2] { 1, 2};
            for (int i = 0; i < myarray.Length; i++)
            {
                if (i>0)
                {
                    Console.WriteLine(myarray[i-1]);
                }
                else
                {
                    Console.WriteLine(myarray[i]);
                }
                
            }
        }
    }
}
