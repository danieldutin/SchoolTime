using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            double difficulty = 0;
            double performance = 0;

            switch (country)
            {
                case "Russia":
                    switch (instrument)
                    {
                       case "ribbon":
                            difficulty = 9.1;
                            performance = 9.4;
                            break;
                        case "hoop":
                            difficulty = 9.3;
                            performance = 9.8;
                            break;
                        case "rope":
                            difficulty = 9.6;
                            performance = 9.0;
                            break;
                    }
                    break;
                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.6;
                            performance = 9.4;
                            break;
                        case "hoop":
                            difficulty = 9.55;
                            performance = 9.75;
                            break;
                        case "rope":
                            difficulty = 9.5;
                            performance = 9.4;
                            break;
                    }
                    break;
                    
                case "Italy":

                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.2;
                            performance = 9.5;
                            break;
                        case "hoop":
                            difficulty = 9.45;
                            performance = 9.5;
                            break;
                        case "rope":
                            difficulty = 9.7;
                            performance = 9.15;
                            break;
                    }
                    break;

                    

            }
            double finalScore = difficulty + performance;
            double percent = (20 - finalScore) / 20 * 100;

            Console.WriteLine($"The team of {country} get {finalScore:f3} on {instrument}.");
            Console.WriteLine($"{percent:f2}% ");
        }
    }
}
