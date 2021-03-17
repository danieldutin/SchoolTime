using System;


namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";
            char reverser;
            int counter = 0;
            for (int i = userName.Length -1; i >= 0; i--)
            {
                reverser = userName[i];
                password += reverser.ToString();
            }

            
            string logInPassword ="";

            while (logInPassword != password)
            {
                
                logInPassword += Console.ReadLine();

                if (logInPassword==password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    counter++;
                }
                if (counter==3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                
                logInPassword = "";
            }
        }
    }
}
