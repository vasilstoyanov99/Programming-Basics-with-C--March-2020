using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double wantedProfit = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalProfit = 0.00;
            bool isWantedProfitAchieved = false;

            while (input != "Party!")
            {
                int numNeededCocktails = int.Parse(Console.ReadLine());
                int totalOrderPrice = numNeededCocktails * input.Length;
                double newPrice = totalOrderPrice;
                string totalOrderPriceStr = totalOrderPrice.ToString();
                int lastNum = 0;

                for (int currentNum = 0; currentNum < totalOrderPriceStr.Length; currentNum++)
                {
                    if (currentNum == totalOrderPriceStr.Length - 1)
                    {
                        lastNum = int.Parse(totalOrderPriceStr[currentNum].ToString());
                    }
                }

                if (lastNum % 3 == 0 && lastNum > 1)
                {
                    newPrice *= 0.75;
                }

                totalProfit += newPrice;

                if (totalProfit >= wantedProfit)
                {
                    isWantedProfitAchieved = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (isWantedProfitAchieved)
            {
                Console.WriteLine("Target acquired.");
            }
            else
            {
                Console.WriteLine($"We need {wantedProfit - totalProfit:f2} leva more.");
            }

            Console.WriteLine($"Club income - {totalProfit:f2} leva.");
        }
    }
}
