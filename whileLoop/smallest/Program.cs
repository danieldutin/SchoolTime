using System;

namespace smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;

            while (true)
            {
                string stop = Console.ReadLine();

                if (stop == "Stop")
                {
                    break;
                }
                int input = int.Parse(stop);
                if (input < smallest)
                {
                    smallest = input;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
