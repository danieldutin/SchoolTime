using System;

namespace Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language;

            switch (country)
            {

                case "England":
                case "USA":
                    language = "English";
                    break;

                case "Spain":
                case "Mexico":
                case "Argentina":
                    language = "Spanish";
                    break;

                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
