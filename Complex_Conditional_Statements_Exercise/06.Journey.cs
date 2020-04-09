using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string location = "";
            string type = "";
            double price = 0.00;
            if(budget <= 100)
            {
                location = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.30;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 0.70;
                    type = "Hotel";
                }       
            }
            else if (budget > 100 && budget <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.40;
                    type = "Camp";
                }

                else if (season == "winter")
                {
                    price = budget * 0.80;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                    type = "Hotel";
                location = "Europe";
                price = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
