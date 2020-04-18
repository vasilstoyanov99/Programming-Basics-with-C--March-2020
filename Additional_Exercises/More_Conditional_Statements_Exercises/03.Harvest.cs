using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int VineYaerd = int.Parse(Console.ReadLine());
            double WineProducedPer = double.Parse(Console.ReadLine());
            int NeededWine = int.Parse(Console.ReadLine());
            int Workers = int.Parse(Console.ReadLine());

            double TotalVine = VineYaerd * WineProducedPer;
            double WineForProduction = (40 * TotalVine) / 100;
            double TotalWineProduced = WineForProduction / 2.50;


            if (TotalWineProduced > NeededWine)
            {
                double WineLeft = TotalWineProduced - NeededWine;
                double WineForWorkers = WineLeft / Workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(TotalWineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(WineLeft)} liters left -> {Math.Ceiling(WineForWorkers)} liters per person.");
            }
            else if (TotalWineProduced < NeededWine)
            {
                double MoreWine = NeededWine - TotalWineProduced;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(MoreWine)} liters wine needed.");

            }
        }
    }
}
