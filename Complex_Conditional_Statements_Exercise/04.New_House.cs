using System;

namespace _04.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch (typeFlower)
            {
                case "Roses":
                    price += 5.00;
                    break;
                case "Dahlias":
                    price += 3.80;
                    break;
                case "Tulips":
                    price += 2.80;
                    break;
                case "Narcissus":
                    price += 3.00;
                    break;
                case "Gladiolus":
                    price += 2.50;
                    break;
            }
            double totalPrice = numFlowers * price;

            if (typeFlower == "Roses" && numFlowers > 80)
                totalPrice *= 0.9;
            else if (typeFlower == "Dahlias" && numFlowers > 90)
                totalPrice *= 0.85;
            else if (typeFlower == "Tulips" && numFlowers > 80)
                totalPrice *= 0.85;
            else if (typeFlower == "Narcissus" && numFlowers < 120)
                totalPrice *= 1.15;
            else if (typeFlower == "Gladiolus" && numFlowers < 80)
                totalPrice *= 1.20;

            if(budget >= totalPrice)
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {typeFlower} and {budget - totalPrice:f2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
        }
    }
}
