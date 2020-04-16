using System;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numVideoCards = int.Parse(Console.ReadLine());
            int numProcessors = int.Parse(Console.ReadLine());
            int numRAM = int.Parse(Console.ReadLine());

            double videoCardsPrice = numVideoCards * 250.00;
            double processorsPrice = (videoCardsPrice * 0.35) * numProcessors;
            double RAMPrice = (0.10 * videoCardsPrice) * numRAM;
            double totalPrice = videoCardsPrice + processorsPrice + RAMPrice;

            if (numVideoCards > numProcessors)
            {
                totalPrice *= 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
