using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string activityLevel = Console.ReadLine();
            double bim = 0;
            if (sex == "m")
            {
                bim = 66 + (13.7 * weight) + (5 * (height * 100)) - (6.8 * age);
                switch (activityLevel)
                {
                    case "sedentary":
                        bim = bim * 1.2;
                        break;
                    case "lightly active":
                        bim = bim * 1.375;
                        break;
                    case "moderately active":
                        bim = bim * 1.55;
                        break;
                    case "very active":
                        bim = bim * 1.725;
                        break;
                }
            }
            else
            {
                bim = 655 + (9.6 * weight) + (1.8 * (height * 100)) - (4.7 * age);
                switch (activityLevel)
                {
                    case "sedentary":
                        bim = bim * 1.2;
                        break;
                    case "lightly active":
                        bim = bim * 1.375;
                        break;
                    case "moderately active":
                        bim = bim * 1.55;
                        break;
                    case "very active":
                        bim = bim * 1.725;
                        break;
                }
            }
            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bim)} calories per day."
);
        }
    }
}
