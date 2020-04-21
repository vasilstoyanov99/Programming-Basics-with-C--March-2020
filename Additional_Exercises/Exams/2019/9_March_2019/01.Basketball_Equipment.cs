using System;

namespace _01.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlySubscriptionFee = int.Parse(Console.ReadLine());

            double shoesPrice = yearlySubscriptionFee * 0.60;
            double outfitPrice = shoesPrice * 0.80;
            double ballPrice = outfitPrice * 1 / 4;
            double accessoriesPrice = ballPrice * 1 / 5;
            double totalCost = yearlySubscriptionFee + shoesPrice + outfitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
