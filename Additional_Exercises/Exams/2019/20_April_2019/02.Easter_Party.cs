using System;

namespace _02.Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsNum = int.Parse(Console.ReadLine());
            double covertPricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());;

            if (guestsNum >= 10 && guestsNum <= 15)
            {
                covertPricePerPerson *= 0.85;
            }
            else if (guestsNum > 15 && guestsNum <= 20)
            {
                covertPricePerPerson *= 0.80;
            }
            else if (guestsNum > 20)
            {
                covertPricePerPerson *= 0.75;
            }

            double cakePrice = budget * 0.10;
            double totalExpenses = cakePrice + (guestsNum * covertPricePerPerson);

            if (budget >= totalExpenses)
            {
                Console.WriteLine($"It is party time! {budget - totalExpenses:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalExpenses - budget:f2} leva needed.");
            }
        }
    }
}
