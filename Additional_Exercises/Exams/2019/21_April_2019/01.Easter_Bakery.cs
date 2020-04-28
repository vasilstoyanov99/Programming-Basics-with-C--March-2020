using System;

namespace _01.Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPricePerKG = double.Parse(Console.ReadLine());
            double flourKG = double.Parse(Console.ReadLine());
            double sugarKG = double.Parse(Console.ReadLine());
            int packsOfEggs = int.Parse(Console.ReadLine());
            int yeastNum = int.Parse(Console.ReadLine());

            double sugarPricePerKG = flourPricePerKG * 0.75;
            double singlePackOfEggsPrice = flourPricePerKG * 1.10;
            double yeastPrice = sugarPricePerKG * 0.20;
            double totalPrice = (flourPricePerKG * flourKG) + (sugarKG * sugarPricePerKG) + (packsOfEggs * singlePackOfEggsPrice) + (yeastNum * yeastPrice);
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
