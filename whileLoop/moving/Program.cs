using System;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //read dimentions;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int volume = x * y * z;
            bool hasSpace = true;
            string input = Console.ReadLine();
            while (hasSpace && input != "Done")
            {
                int boxes = int.Parse(input);
                
                volume -= boxes;

                if (volume < 0)
                {
                    hasSpace = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (hasSpace)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
            
            //read boxes count;

            //check if hasSpace

            //print output 1.No more space2.done.
        }
    }
}
