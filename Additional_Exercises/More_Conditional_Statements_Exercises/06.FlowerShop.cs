using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int mangoli = int.Parse(Console.ReadLine());
            int zqmbqli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double GiftPrice = double.Parse(Console.ReadLine());

            double MoneyFromFlowrs = (mangoli * 3.25) + (zqmbqli * 4.0) + (rozi * 3.50) + (kaktusi * 8.0);
            double Tax = (MoneyFromFlowrs * 5) / 100;
            double TotalMoney = MoneyFromFlowrs - Tax;

            if (TotalMoney >= GiftPrice)
            {
                double LeftMoney = TotalMoney - GiftPrice;
                Console.WriteLine($"She is left with {Math.Truncate(LeftMoney)} leva.");
            }
            else if (TotalMoney < GiftPrice)
            {
                double NeededMoney = GiftPrice - TotalMoney;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(NeededMoney)} leva.");
            }
        }
    }
}
