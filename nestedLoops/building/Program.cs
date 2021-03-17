using System;

namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the input
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int floorDigit = 0;
            int roomDigit = 0;
            string propertyType = "";

            for (int i = 0; i < rooms; i++)
            {
                Console.Write($"L{floors}{i} ");
            }

            Console.WriteLine();

            for (int i = floors - 1; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {

                    
                    if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                        
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                        
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
