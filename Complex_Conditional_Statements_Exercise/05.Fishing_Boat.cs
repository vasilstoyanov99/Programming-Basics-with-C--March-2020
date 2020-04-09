using System;

namespace _05.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFisherman = int.Parse(Console.ReadLine());
            double boatPrice = 0;
            switch (season)
            {
                case "Spring":
                    boatPrice += 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice += 4200;
                    break;
                case "Winter":
                    boatPrice += 2600;
                    break;
            }
            if (numFisherman <= 6)
                boatPrice *= 0.90;
            else if (numFisherman >= 7 && numFisherman <= 11)
                boatPrice *= 0.85;
            else if (numFisherman >= 12)
                boatPrice *= 0.75;
            if (numFisherman % 2 == 0 && season != "Autumn")
                boatPrice *= 0.95;
            
            if(budget >= boatPrice)
                Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
            else if (budget < boatPrice)
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");
        }
    }
}
