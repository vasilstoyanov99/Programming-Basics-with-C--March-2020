using System;

namespace _06.Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int moviesCounter = 0;
            int movieForYouPoints = int.MinValue;
            string movieForYou = "";

            while (input != "STOP")
            {
                string MovieName = input;
                moviesCounter++;
                int moviePoints = 0;
                int reducedPoints = 0;
                for (int currentCharPlace = 0; currentCharPlace < MovieName.Length; currentCharPlace++)
                {
                    char currentChar = MovieName[currentCharPlace];
                    moviePoints += currentChar;

                    if (currentChar >= 97 && currentChar <= 122)
                    {
                        reducedPoints += MovieName.Length * 2;
                    }
                    else if (currentChar >= 65 && currentChar <= 90)
                    {
                        reducedPoints += MovieName.Length;
                    }
                }

                moviePoints -= reducedPoints;

                if (moviePoints > movieForYouPoints)
                {
                    movieForYouPoints = moviePoints;
                    movieForYou = MovieName; 
                }

                if (moviesCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {movieForYou} with {movieForYouPoints} ASCII sum.");
        }
    }
}
