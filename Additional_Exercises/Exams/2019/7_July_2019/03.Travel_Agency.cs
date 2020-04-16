using System;

namespace _03.Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string typePackage = Console.ReadLine();
            string isVIPCard = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0.00;

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    switch (typePackage)
                    {
                        case "withEquipment":
                            pricePerDay = 100.00;
                            if (isVIPCard == "yes")
                            {
                                pricePerDay *= 0.90;
                            }
                            break;
                        case "noEquipment":
                            pricePerDay = 80.00;
                            if (isVIPCard == "yes")
                            {
                                pricePerDay *= 0.95;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (typePackage)
                    {
                        case "withBreakfast":
                            pricePerDay = 130.00;
                            if (isVIPCard == "yes")
                            {
                                pricePerDay *= 0.88;
                            }
                            break;
                        case "noBreakfast":
                            pricePerDay = 100.00;
                            if (isVIPCard == "yes")
                            {
                                pricePerDay *= 0.93;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }

            if (days > 7)
            {
                days--;
            }

            double totalPrice = days * pricePerDay;
            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}
