using System;

namespace skiingTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = (int.Parse(Console.ReadLine())) - 1;
            string typeOfAccomodation = Console.ReadLine().ToLower();
            string feedbackReview = Console.ReadLine().ToLower();

            double roomForOne = 18.00;
            double apartment = 25.00;
            double presidentSuit = 35.00;   

            double cost = 0;

            if (true)
            {

            }

            //switch (typeOfAccomodation)
            //{
            //    case "room for one person":
            //        cost = numberOfDays * roomForOne;
            //        break;
            //    case "apartment":
            //        cost = numberOfDays * apartment;
            //        break;
            //    case "president apartment":
            //        cost = numberOfDays * presidentSuit;
            //        break;

            //}
            ////
            //if (numberOfDays < 10 && typeOfAccomodation == "apartment")
            //{
            //    cost = cost - (apartment * 30 / 100);
            //}
            //else if (numberOfDays > 10 && numberOfDays < 15 && typeOfAccomodation == "apartment")
            //{
            //    cost = cost - (apartment * 35 / 100);
            //}
            //else if (numberOfDays > 15 && typeOfAccomodation == "apartment")
            //{
            //    cost = cost - (apartment * 50 / 100);
            //}
            ////
            //else if (numberOfDays < 10 && typeOfAccomodation == "president apartment")
            //{
            //    cost = cost - (presidentSuit * 10 / 100);
            //}
            //else if (numberOfDays > 10 && numberOfDays < 15 && typeOfAccomodation == "president apartment")
            //{
            //    cost = cost - (presidentSuit * 15 / 100);
            //}
            //else if (numberOfDays > 15 && typeOfAccomodation == "president apartment")
            //{
            //    cost = cost - (presidentSuit * 20 / 100);
            //}
            ////
            //else if (typeOfAccomodation == "roon for one person")
            //{
            //    cost = numberOfDays * roomForOne;
            //}
            

            //if (feedbackReview == "positive")
            //{
                

            //    cost = cost + (cost * 25 / 100);

            //}
            //else if (feedbackReview == "negative")
            //{
            //    cost = cost - (cost * 10 / 100);
            //}

            //Console.WriteLine($"{cost:f2}");

        }
    }
}
