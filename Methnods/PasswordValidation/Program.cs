using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string errorLettersAndDigits = "Password must consist only of letters and digits";
            string errorLessThanTwo = "Password must have at least 2 digits";
            string error6and10 = "Password must be between 6 and 10 characters";
            string valid = "Password is valid";

            bool validInput = true;
            bool lenght = true;
            bool letAndDig = true;

            

            int digitCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {

                if (password.Length < 6 || password.Length > 10)
                {
                    lenght = false;
                    validInput = false;
                }

                if (Char.IsDigit(password[i]))
                {
                    digitCounter++;
                }

                if (!Char.IsDigit(password[i]) && !Char.IsLetter(password[i]))
                {
                    letAndDig = false;
                    validInput = false;
                }

            }

            if (!lenght)
            {
                Console.WriteLine(error6and10);
            }

            if (!letAndDig)
            {
                Console.WriteLine(errorLettersAndDigits);
            }
            if (digitCounter<2)
            {
                Console.WriteLine(errorLessThanTwo);
                validInput = false;
            }
            else if(validInput)
            {
                Console.WriteLine(valid);
            }
        }
    }
}
