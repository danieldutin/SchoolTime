using System;

namespace testField
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int fact5=1;
            int counter = 1;
            while (true)
            {
                fact5 = fact5 * counter;
                counter++;
                if (counter==number+1)
                {
                    break;
                }
            }
            Console.WriteLine(fact5);
        }
    }
}
