using System;

namespace _06.Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalClients = int.Parse(Console.ReadLine());
            double totalSpendMoney = 0.00;

            for (int currentClient = 0; currentClient < totalClients; currentClient++)
            {
                string input = Console.ReadLine();
                int totalBoughtProducts = 0;
                double totalPrice = 0.00;
                
                while (input != "Finish")
                {
                    string typePurchase = input;
                    totalBoughtProducts++;

                    if (typePurchase == "basket")
                    {
                        totalPrice += 1.50;
                    }
                    else if (typePurchase == "wreath")
                    {
                        totalPrice += 3.80;
                    }
                    else if (typePurchase == "chocolate bunny")
                    {
                        totalPrice += 7.00;
                    }

                    input = Console.ReadLine();
                }

                if (totalBoughtProducts % 2 == 0)
                {
                    totalPrice *= 0.80;
                    totalSpendMoney += totalPrice;
                }
                else
                {
                    totalSpendMoney += totalPrice;
                }

                Console.WriteLine($"You purchased {totalBoughtProducts} items for {totalPrice:f2} leva.");
            }

            Console.WriteLine($"Average bill per client is: {totalSpendMoney / totalClients:f2} leva.");
        }
    }
}
