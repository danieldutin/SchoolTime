using System;

namespace vegOrfruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string output = "";
            switch (input)
            {
                case "tomato":
                case "cucumber":
                case "carrot":
                case "pepper":
                    output = "vegetable";
                    break;
                case "banana":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                case "apple":
                    output = "fruit";
                    break;

                

                default:
                    output = "unknown";
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
