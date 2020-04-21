using System;

namespace _03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string typePlayWith = Console.ReadLine();
            double difficultyPoints = 0.00;
            double playPoints = 0.00;

            if (typePlayWith == "ribbon")
            {
                switch (country)
                {
                    case "Russia":
                        difficultyPoints = 9.100;
                        playPoints = 9.400;
                        break;
                    case "Bulgaria":
                        difficultyPoints = 9.600;
                        playPoints = 9.400;
                        break;
                    case "Italy":
                        difficultyPoints = 9.200;
                        playPoints = 9.500;
                        break;
                }
            }
            else if (typePlayWith == "hoop")
            {
                switch (country)
                {
                    case "Russia":
                        difficultyPoints = 9.300;
                        playPoints = 9.800;
                        break;
                    case "Bulgaria":
                        difficultyPoints = 9.550;
                        playPoints = 9.750;
                        break;
                    case "Italy":
                        difficultyPoints = 9.450;
                        playPoints = 9.350;
                        break;
                }
            }
            else if (typePlayWith == "rope")
            {
                switch (country)
                {
                    case "Russia":
                        difficultyPoints = 9.600;
                        playPoints = 9.000;
                        break;
                    case "Bulgaria":
                        difficultyPoints = 9.500;
                        playPoints = 9.400;
                        break;
                    case "Italy":
                        difficultyPoints = 9.700;
                        playPoints = 9.150;
                        break;
                }
            }

            double totalPoints = difficultyPoints + playPoints;
            double neededPoints = 20 - totalPoints;
            Console.WriteLine($"The team of {country} get {totalPoints:f3} on {typePlayWith}.");
            Console.WriteLine($"{neededPoints / 20.000 * 100:f2}%");
        }
    }
}
