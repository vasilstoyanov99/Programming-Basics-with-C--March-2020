using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double neededLitersFuel = double.Parse(Console.ReadLine());
            string dayOfTheWeekend = Console.ReadLine();

            double totalFuelExpense = neededLitersFuel * 2.10;
            double totalExpenses = totalFuelExpense + 100.00;

            if (dayOfTheWeekend == "Saturday")
            {
                totalExpenses *= 0.90;
            }
            else if (dayOfTheWeekend == "Sunday")
            {
                totalExpenses *= 0.80;
            }

            if (budget >= totalExpenses)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalExpenses:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalExpenses - budget:f2} lv.");
            }
        }
    }
}
