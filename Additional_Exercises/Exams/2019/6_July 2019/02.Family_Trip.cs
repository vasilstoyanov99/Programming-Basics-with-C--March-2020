using System;

namespace _02.Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double numOvernights = double.Parse(Console.ReadLine());
            double overNightPrice = double.Parse(Console.ReadLine());
            double perAdditExpenses = double.Parse(Console.ReadLine());

            double additExpenses = (budget * perAdditExpenses) / 100;
            budget -= additExpenses;

            if (numOvernights > 7)
            {
                overNightPrice *= 0.95;
            }

            double totalPrice = numOvernights * overNightPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:f2} leva needed.");
            }
        }
    }
}
