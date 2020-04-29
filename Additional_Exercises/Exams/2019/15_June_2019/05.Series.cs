using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int wantedSerialsToBuy = int.Parse(Console.ReadLine());
            double spendMoney = 0.00;

            for (int currentSerial = 0; currentSerial < wantedSerialsToBuy; currentSerial++)
            {
                string serialName = Console.ReadLine();
                double serialPrice = double.Parse(Console.ReadLine());

                switch (serialName)
                {
                    case "Thrones":
                        serialPrice *= 0.50;
                        break;
                    case "Lucifer":
                        serialPrice *= 0.60;
                        break;
                    case "Protector":
                        serialPrice *= 0.70;
                        break;
                    case "TotalDrama":
                        serialPrice *= 0.80;
                        break;
                    case "Area":
                        serialPrice *= 0.90;
                        break;
                }

                spendMoney += serialPrice;
            }

            if (budget >= spendMoney)
            {
                Console.WriteLine($"You bought all the series and left with {budget - spendMoney:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {spendMoney - budget:f2} lv. more to buy the series!");
            }
        }
    }
}
