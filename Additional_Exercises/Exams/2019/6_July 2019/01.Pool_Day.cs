using System;

namespace _01.Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPeople = double.Parse(Console.ReadLine());
            double entryFee = double.Parse(Console.ReadLine());
            double deckChairFee = double.Parse(Console.ReadLine());
            double umbrellaFee = double.Parse(Console.ReadLine());

            double neededDeckChairs = Math.Ceiling(numPeople * 0.75);
            double neededUmbrellas = Math.Ceiling(numPeople / 2);

            double totalDeckChairFee = neededDeckChairs * deckChairFee;
            double totalUmbrellaFee = neededUmbrellas * umbrellaFee;
            double totalFees = totalDeckChairFee + totalUmbrellaFee + (numPeople * entryFee);

            Console.WriteLine($"{totalFees:f2} lv.");
        }
    }
}
