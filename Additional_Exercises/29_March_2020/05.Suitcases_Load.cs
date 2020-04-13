using System;

namespace _05.Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double airplaneTrunkCapacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int numLoadedSuitcases = 0;
            int checker = 0;
            bool noMoreSpace = false;
            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);

                checker++;

                if (checker % 3 == 0)
                {
                    suitcaseVolume *= 1.10;
                }

                if (airplaneTrunkCapacity < suitcaseVolume)
                {
                    noMoreSpace = true;
                    break;
                }

                numLoadedSuitcases++;

                if (numLoadedSuitcases % 3 == 0)
                {
                    airplaneTrunkCapacity -= suitcaseVolume;
                }
                else
                {
                    airplaneTrunkCapacity -= suitcaseVolume;
                }              
                input = Console.ReadLine();
            }

            if (noMoreSpace)
            {
                Console.WriteLine("No more space!");
            }
            else
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {numLoadedSuitcases} suitcases loaded.");
        }
    }
}
