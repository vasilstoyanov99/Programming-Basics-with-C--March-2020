using System;

namespace _02.Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsNum = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double kozunaciNum = Math.Ceiling(guestsNum / 3.0);
            double kozunaciPrice = kozunaciNum * 4.00;
            int eggsNum = guestsNum * 2;
            double eggsPrice = eggsNum * 0.45;
            double totalExpenses = kozunaciPrice + eggsPrice;

            if (budget < totalExpenses)
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalExpenses - budget:f2} lv. more.");
            }
            else
            {
                Console.WriteLine($"Lyubo bought {kozunaciNum} Easter bread and {eggsNum} eggs.");
                Console.WriteLine($"He has {budget - totalExpenses:f2} lv. left.");
            }
        }
    }
}
