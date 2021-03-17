using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("What gender are you?");
            string gender = Console.ReadLine().ToLower();
            string output = "";
            if (gender == "f")
            {
                if (age<16)
                {
                    output = "Miss";
                }
                else
                {
                    output = "Ms.";
                }
            }
            else if (gender == "m")
            {
                if(age < 16)
                {
                    output = "Master";
                }
                else
                {
                    output = "Mr.";
                }
            }
            
            Console.WriteLine(output);
        }
    }
}
