using System;

namespace _01.Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numKozunaci = int.Parse(Console.ReadLine());
            int numEggsPacks = int.Parse(Console.ReadLine());
            int SweetsKG = int.Parse(Console.ReadLine());

            double eggsPaintPrice = (numEggsPacks * 12) * 0.15;
            double eggsPrice = numEggsPacks * 4.35;
            double kozunaciPrice = numKozunaci * 3.20;
            double sweetsPrice = SweetsKG * 5.40;
            double totalPrice = eggsPaintPrice + eggsPrice + kozunaciPrice + sweetsPrice;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
