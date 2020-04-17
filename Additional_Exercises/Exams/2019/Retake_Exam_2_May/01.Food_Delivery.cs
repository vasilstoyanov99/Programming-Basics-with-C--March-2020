using System;

namespace _01.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenOrders = int.Parse(Console.ReadLine());
            int fishOrders = int.Parse(Console.ReadLine());
            int vegetarianOrders = int.Parse(Console.ReadLine());

            double totalChikenOrderPrice = chickenOrders * 10.35;
            double totalFishOrderPrice = fishOrders * 12.40;
            double totalVegetarianOrderPrice = vegetarianOrders * 8.15;
            double totalPrice = totalChikenOrderPrice + totalFishOrderPrice + totalVegetarianOrderPrice;
            double dessertPrice = totalPrice * 0.20;
            totalPrice += dessertPrice + 2.50;

            Console.WriteLine($"Total: {totalPrice:f2}");
        }
    }
}
