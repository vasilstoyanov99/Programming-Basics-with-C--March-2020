using System;

namespace _05.PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numSoldGames = double.Parse(Console.ReadLine());
            double HearthstoneCounter = 0.00;
            double ForniteCounter = 0.00;
            double OverwatchCounter = 0.00;
            double OthersCounter = 0.00;

            for (int currentSoldGame = 1; currentSoldGame <= numSoldGames; currentSoldGame++)
            {
                string gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "Hearthstone":
                        HearthstoneCounter++;
                        break;
                    case "Fornite":
                        ForniteCounter++;
                        break;
                    case "Overwatch":
                        OverwatchCounter++;
                        break;
                    default:
                        OthersCounter++;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {HearthstoneCounter / numSoldGames * 100:f2}%");
            Console.WriteLine($"Fornite - {ForniteCounter / numSoldGames * 100:f2}%");
            Console.WriteLine($"Overwatch - {OverwatchCounter / numSoldGames * 100:f2}%");
            Console.WriteLine($"Others - {OthersCounter  / numSoldGames * 100:f2}%");
        }
    }
}
