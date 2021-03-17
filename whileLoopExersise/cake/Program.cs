using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakePeaces = width * lenght;

            string comands = Console.ReadLine();

            while (cakePeaces >= 0)
            {
                if (comands == "STOP")
                {
                    break;
                }

                int cake = int.Parse(comands);
                cakePeaces -= cake;
                comands = Console.ReadLine();

            }

            if (cakePeaces >= 0)
            {
                Console.WriteLine($"{cakePeaces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePeaces)} pieces more.");
            }
        }
    }
}
