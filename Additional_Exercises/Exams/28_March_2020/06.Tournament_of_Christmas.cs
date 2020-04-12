using System;

namespace _06.Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            int totalWinsCount = 0;
            int totalLosesCount = 0;
            double totalRaisedMoney = 0.00;

            for (int currentDay = 1; currentDay <= tournamentDays; currentDay++)
            {
                bool isDayFinished = false;
                int winsForTheDay = 0;
                int losesForTheDay = 0;
                double moneyRaisedDay = 0.00;

                while (!isDayFinished)
                {
                    string typeSport = Console.ReadLine();
                    if (typeSport == "Finish")
                    {
                        isDayFinished = true;
                        break;
                    }
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        moneyRaisedDay += 20.00;
                        winsForTheDay++;
                        totalWinsCount++;
                    }
                    else if (result == "lose")
                    {
                        losesForTheDay++;
                        totalLosesCount++;
                    }
                }

                if (winsForTheDay > losesForTheDay)
                {
                    moneyRaisedDay *= 1.10;
                    totalRaisedMoney += moneyRaisedDay;
                }
                else
                {
                    totalRaisedMoney += moneyRaisedDay;
                }
            }

            if (totalWinsCount > totalLosesCount)
            {
                totalRaisedMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalRaisedMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalRaisedMoney:f2}");
            }

        }
    }
}
