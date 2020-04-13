using System;

namespace _03.Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string typeSport = Console.ReadLine();
            double priceForCard = 0.00;

            if (gender == "m")
            {
                switch (typeSport)
                {
                    case "Gym":
                        priceForCard += 42.00;
                        break;
                    case "Boxing":
                        priceForCard += 41.00;
                        break;
                    case "Yoga":
                        priceForCard += 45.00;
                        break;
                    case "Zumba":
                        priceForCard += 34.00;
                        break;
                    case "Dances":
                        priceForCard += 51.00;
                        break;
                    case "Pilates":
                        priceForCard += 39.00;
                        break;
                }
            }

            else if (gender == "f")
            {
                switch (typeSport)
                {
                    case "Gym":
                        priceForCard += 35.00;
                        break;
                    case "Boxing":
                        priceForCard += 37.00;
                        break;
                    case "Yoga":
                        priceForCard += 42.00;
                        break;
                    case "Zumba":
                        priceForCard += 31.00;
                        break;
                    case "Dances":
                        priceForCard += 53.00;
                        break;
                    case "Pilates":
                        priceForCard += 37.00;
                        break;
                }
            }

            if (age <= 19)
            {
                priceForCard *= 0.80;
            }

            if (availableMoney >= priceForCard)
            {
                Console.WriteLine($"You purchased a 1 month pass for {typeSport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${priceForCard - availableMoney:f2} more.");
            }
        }
    }
}
