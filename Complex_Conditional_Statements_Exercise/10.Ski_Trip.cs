using System;

namespace _10.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine().ToLower();
            string rating = Console.ReadLine().ToLower();
            double price = 0.00; // for a night
            switch (typeRoom)
            {
                case "room for one person":
                    price += 18.00;
                    break;
                case "apartment":
                    price += 25.00;
                    break;
                case "president apartment":
                    price += 35.00;
                    break;
            }
            double totalPrice = (daysStay - 1) * price;
            if(daysStay < 10)
            {
                switch (typeRoom)
                {
                    case "apartment":
                        totalPrice *= 0.70;
                        break;
                    case "president apartment":
                        totalPrice *= 0.90;
                        break;
                }
            }
            else if (daysStay >= 10 && daysStay <= 15)
            {
                switch (typeRoom)
                {
                    case "apartment":
                        totalPrice *= 0.65;
                        break;
                    case "president apartment":
                        totalPrice *= 0.85;
                        break;
                }
            }
            else if (daysStay > 15)
            {
                switch (typeRoom)
                {
                    case "apartment":
                        totalPrice *= 0.50;
                        break;
                    case "president apartment":
                        totalPrice *= 0.80;
                        break;
                }
            }
            if(rating == "positive")
            {
                totalPrice *= 1.25;
            }
            else if(rating == "negative")
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
