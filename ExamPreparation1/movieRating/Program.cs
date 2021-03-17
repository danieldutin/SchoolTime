using System;

namespace movieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMovies = int.Parse(Console.ReadLine());
            double minRating = double.MaxValue;
            string worstMovie = "";
            double maxRating = double.MinValue;
            string bestMovie = "";

            double sum = 0;

            for (int i = 0; i < countOfMovies; i++)
            {
                string text = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating > maxRating)
                {
                    maxRating = rating;
                    bestMovie = text;
                }
                if (rating<minRating)
                {
                    minRating = rating;
                    worstMovie = text;
                }
                sum += rating;
            }
            double average = sum / countOfMovies;
            Console.WriteLine($"{bestMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
