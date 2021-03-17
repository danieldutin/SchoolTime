using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniReception
{

    class Program
    {
        static void Main(string[] args)
        {
            ushort firstCapacity = ushort.Parse(Console.ReadLine());
            ushort secondCapacity = ushort.Parse(Console.ReadLine());
            ushort thirdCapacity = ushort.Parse(Console.ReadLine());
            ushort numOfPeople = ushort.Parse(Console.ReadLine());

            int perHour = firstCapacity + secondCapacity + thirdCapacity;

            int hoursNeeded = (int)Math.Ceiling(numOfPeople / (double)perHour);
            
            hoursNeeded += hoursNeeded/4;
            if (hoursNeeded%4==0)
            {
                hoursNeeded--;
            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}
