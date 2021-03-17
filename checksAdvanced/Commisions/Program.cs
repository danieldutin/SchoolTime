using System;

namespace Commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double salesVolume = double.Parse(Console.ReadLine());
            double comission = 0;
            if ((city == "sofia" || city == "varna" || city == "plovdiv") && salesVolume > 0)
            {
            switch (city)
            {   

                case "sofia":

                    if (salesVolume <= 500)
                    {
                        comission = 5;
                    }
                    else if (salesVolume <= 1000)
                    {
                        comission = 7;
                    }
                    else if (salesVolume <= 10000)
                    {
                        comission = 8;
                    }
                    else
                    {
                        comission = 12;
                    }
                    break;

                case "varna":

                    if (salesVolume <= 500)
                    {
                        comission = 4.50;
                    }
                    else if (salesVolume <= 1000)
                    {
                        comission = 7.50;
                    }
                    else if (salesVolume <= 10000)
                    {
                        comission = 10;
                    }
                    else
                    {
                        comission = 13;
                    }
                    break;

                case "plovdiv":

                    if (salesVolume <= 500)
                    {
                        comission = 5.50;
                    }
                    else if (salesVolume <= 1000)
                    {
                        comission = 8;
                    }
                    else if (salesVolume <= 10000)
                    {
                        comission = 12;
                    }
                    else
                    {
                        comission = 14.50;
                    }
                    break;
              
            }
                double salesmanCut = salesVolume * comission / 100;
                Console.WriteLine($"{salesmanCut:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

            
        }
    }
}
