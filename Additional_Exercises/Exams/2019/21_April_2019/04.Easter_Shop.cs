using System;

namespace _04.Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEggs = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalSoldEggs = 0;

            while (input != "Close")
            {
                if (input == "Buy")
                {
                    int wantedEggs = int.Parse(Console.ReadLine());

                    if (wantedEggs > totalEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {totalEggs}.");
                        break;
                    } 

                    totalEggs -= wantedEggs;
                    totalSoldEggs += wantedEggs;
                }
                else if (input == "Fill")
                {
                    int addedEggs = int.Parse(Console.ReadLine());
                    totalEggs += addedEggs;
                }

                input = Console.ReadLine();
            }

            if (input == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{totalSoldEggs} eggs sold.");
            }
        }
    }
}
