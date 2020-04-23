using System;

namespace _03.World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfRound = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            string picWithTrophy = Console.ReadLine();
            double pricePerTicket = 0.00;
            bool isPicWithTrophyFree = false;

            if (typeOfRound == "Quarter final")
            {
                switch (typeTicket)
                {
                    case "Standard":
                        pricePerTicket = 55.50;
                        break;
                    case "Premium":
                        pricePerTicket = 105.20;
                        break;
                    case "VIP":
                        pricePerTicket = 118.90;
                        break;
                }
            }
            else if (typeOfRound == "Semi final")
            {
                switch (typeTicket)
                {
                    case "Standard":
                        pricePerTicket = 75.88;
                        break;
                    case "Premium":
                        pricePerTicket = 125.22;
                        break;
                    case "VIP":
                        pricePerTicket = 300.40;
                        break;
                }
            }
            else if (typeOfRound == "Final")
            {
                switch (typeTicket)
                {
                    case "Standard":
                        pricePerTicket = 110.10;
                        break;
                    case "Premium":
                        pricePerTicket = 160.66;
                        break;
                    case "VIP":
                        pricePerTicket = 400.00;
                        break;
                }
            }

            double totalPrice = pricePerTicket * numTickets;

            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice *= 0.90;
            }
            else if (totalPrice > 4000)
            {
                totalPrice *= 0.75;

                if (picWithTrophy == "Y")
                {
                    isPicWithTrophyFree = true;
                }
            }

            if (picWithTrophy == "Y" && !isPicWithTrophyFree)
            {
                totalPrice += (numTickets * 40.00);
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
