using System;

namespace _04.Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName = Console.ReadLine();
            int productCounter = 0;
            double totalSpendMoney = 0.00;
            double lastProductPrice = 0.00;
            bool isTooExpensive = false;

            while (productName != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                productCounter++;

                if (productCounter % 3 == 0)
                {
                    productPrice /= 2;
                }

                if (productPrice > budget)
                {
                    isTooExpensive = true;
                    lastProductPrice = productPrice;
                    break;
                }

                budget -= productPrice;
                totalSpendMoney += productPrice;
                productName = Console.ReadLine();
            }

            if (!isTooExpensive)
            {
                Console.WriteLine($"You bought {productCounter} products for {totalSpendMoney:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {lastProductPrice - budget:f2} leva!");
            }
        }
    }
}
