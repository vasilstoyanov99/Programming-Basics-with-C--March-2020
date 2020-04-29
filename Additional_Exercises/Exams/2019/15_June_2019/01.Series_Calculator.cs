using System;

namespace _01.Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int seasonsNum = int.Parse(Console.ReadLine());
            int episodesPerSeason = int.Parse(Console.ReadLine());
            double episodeWithoutAdsTime = double.Parse(Console.ReadLine());

            double episodeWithAdsTime = episodeWithoutAdsTime * 1.20;
            double specialEpisodeAddTime = seasonsNum * 10;
            double totalWatchTime = ((seasonsNum * episodesPerSeason) * episodeWithAdsTime) + specialEpisodeAddTime;
            Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Floor(totalWatchTime)} minutes.");
        }
    }
}
