using System;

namespace _07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double WiskeyPrice = double.Parse(Console.ReadLine());
            double LitersBeer = double.Parse(Console.ReadLine());
            double LitersWine = double.Parse(Console.ReadLine());
            double LitersRakia = double.Parse(Console.ReadLine());
            double LitersWiskey = double.Parse(Console.ReadLine());

            double RakiaPrice = WiskeyPrice / 2;
            double WinePrice = RakiaPrice - (RakiaPrice * 0.4);
            double BeerPrice = RakiaPrice - (RakiaPrice * 0.8);
            double TotalMoney = (WiskeyPrice * LitersWiskey) + (LitersBeer * BeerPrice) + (LitersWine * WinePrice) + (LitersRakia * RakiaPrice);

            Console.WriteLine($"{TotalMoney:f2}");
        }
    }
}
