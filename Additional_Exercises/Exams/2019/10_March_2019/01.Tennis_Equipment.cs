using System;

namespace _01.Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisPacketPrice = double.Parse(Console.ReadLine());
            int neededTennisPackets = int.Parse(Console.ReadLine());
            int neededShoes = int.Parse(Console.ReadLine());
            double onePairOfShoesPrice = tennisPacketPrice * 1 / 6;
            double totalRacketsAndShoesPrice = (tennisPacketPrice * neededTennisPackets) + (neededShoes * onePairOfShoesPrice);
            double otherEquipmentPrice = totalRacketsAndShoesPrice * 0.20;
            double totalExpenses = otherEquipmentPrice + totalRacketsAndShoesPrice;
            double pricePaidByDjokovic = totalExpenses / 8;
            double pricePaidBySponsors = totalExpenses * 7 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(pricePaidByDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(pricePaidBySponsors)}");
        }
    }
}
