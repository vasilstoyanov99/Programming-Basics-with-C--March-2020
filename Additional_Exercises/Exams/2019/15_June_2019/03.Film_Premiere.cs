using System;

namespace _03.Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string typeSnacPack = Console.ReadLine();
            int ticketsNum = int.Parse(Console.ReadLine());
            int totalPricePerPerson = 0;

            if (movieName == "John Wick")
            {
                switch (typeSnacPack)
                {
                    case "Drink":
                        totalPricePerPerson = 12;
                        break;
                    case "Popcorn":
                        totalPricePerPerson = 15;
                        break;
                    case "Menu":
                        totalPricePerPerson = 19;
                        break;
                }
            }
            else if (movieName == "Star Wars")
            {
                switch (typeSnacPack)
                {
                    case "Drink":
                        totalPricePerPerson = 18;
                        break;
                    case "Popcorn":
                        totalPricePerPerson = 25;
                        break;
                    case "Menu":
                        totalPricePerPerson = 30;
                        break;
                }
            }
            else if (movieName == "Jumanji")
            {
                switch (typeSnacPack)
                {
                    case "Drink":
                        totalPricePerPerson = 9;
                        break;
                    case "Popcorn":
                        totalPricePerPerson = 11;
                        break;
                    case "Menu":
                        totalPricePerPerson = 14;
                        break;
                }
            }

            double totalPrice = ticketsNum * totalPricePerPerson;

            if (movieName == "Star Wars" && ticketsNum >= 4)
            {
                totalPrice *= 0.70;
            }

            if (movieName == "Jumanji" && ticketsNum == 2)
            {
                totalPrice *= 0.85;
            }

            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
        }
    }
}
