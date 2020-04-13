using System;

namespace _01.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPens = double.Parse(Console.ReadLine());
            double numMarkers = double.Parse(Console.ReadLine());
            double litersBoardCleaner = double.Parse(Console.ReadLine());
            double perDiscount = double.Parse(Console.ReadLine());

            double pricePens = numPens * 5.80;
            double priceMarkers = numMarkers * 7.20;
            double priceBoardCleaner = litersBoardCleaner * 1.20;
            double sumedPrice = pricePens + priceMarkers + priceBoardCleaner;
            double discount = sumedPrice * perDiscount / 100;
            double totalPrice = sumedPrice - discount;

            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}
