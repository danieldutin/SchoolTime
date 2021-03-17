using System;

namespace biggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggest = int.MinValue;
            
            while (true)
            {
                string stop = Console.ReadLine();
                
                if (stop == "Stop")
                {
                    break;
                }
                int input = int.Parse(stop);
                if (input > biggest)
                {
                    biggest = input;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
