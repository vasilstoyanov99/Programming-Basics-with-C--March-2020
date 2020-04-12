using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededЕxcursionBudget = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCount = 0;
            int daysSpendingCount = 0;
            bool isSaved = false;

            while (!isSaved)
            {
                string typeAction = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                daysCount++;

                if (typeAction == "spend")
                {
                    availableMoney -= currentMoney;
                    daysSpendingCount++;

                    if (availableMoney <= 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (typeAction == "save")
                {
                    availableMoney += currentMoney;
                    daysSpendingCount = 0;
                }
                if (daysSpendingCount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCount}");
                    break;
                }

                if  (availableMoney >= neededЕxcursionBudget)
                {
                    isSaved = true;
                }
            }

            if (isSaved)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
