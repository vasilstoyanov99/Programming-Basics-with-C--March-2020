using System;

namespace _06.Godzilla_VS_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budget = double.Parse(Console.ReadLine());
            int Extras = int.Parse(Console.ReadLine());
            double OutfitExtraPrice = double.Parse(Console.ReadLine());

            double Decor = Budget * 0.10;
            if (Extras > 150)
                OutfitExtraPrice *= 0.90;
            double TotalExtaPrice = Extras * OutfitExtraPrice;
            double TotalSpending = Decor + TotalExtaPrice; 

            if(TotalSpending > Budget)
            {
                double NeededMoney = TotalSpending - Budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {NeededMoney:f2} leva more.");
            }
            else if(TotalSpending <= Budget)
            {
                double LeftMoney = Budget - TotalSpending;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {LeftMoney:f2} leva left.");
            }
        }
    }
}
