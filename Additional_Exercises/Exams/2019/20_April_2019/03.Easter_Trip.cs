using System;

namespace _03.Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string datesOfReservation = Console.ReadLine();
            int overnightsNum = int.Parse(Console.ReadLine());
            int pricePerOvernight = 0;

            if (datesOfReservation == "21-23")
            {
                switch (destination)
                {
                    case "France":
                        pricePerOvernight = 30;
                        break;
                    case "Italy":
                        pricePerOvernight = 28;
                        break;
                    case "Germany":
                        pricePerOvernight = 32;
                        break;
                }
            }
            else if (datesOfReservation == "24-27")
            {
                switch (destination)
                {
                    case "France":
                        pricePerOvernight = 35;
                        break;
                    case "Italy":
                        pricePerOvernight = 32;
                        break;
                    case "Germany":
                        pricePerOvernight = 37;
                        break;
                }
            }
            else if (datesOfReservation == "28-31")
            {
                switch (destination)
                {
                    case "France":
                        pricePerOvernight = 40;
                        break;
                    case "Italy":
                        pricePerOvernight = 39;
                        break;
                    case "Germany":
                        pricePerOvernight = 43;
                        break;
                }
            }

            int totalTripCost = overnightsNum * pricePerOvernight;
            Console.WriteLine($"Easter trip to {destination} : {totalTripCost:f2} leva.");
        }
    }
}
