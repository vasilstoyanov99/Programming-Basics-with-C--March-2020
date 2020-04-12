using System;

namespace _05.Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodKG = int.Parse(Console.ReadLine());
            int foodGrams = foodKG * 1000;
            int totalEatenFood = 0;
            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                int eatenFood = int.Parse(input);
                totalEatenFood += eatenFood;
                input = Console.ReadLine();
            }

            if (totalEatenFood <= foodGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodGrams - totalEatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - foodGrams} grams more.");
            }
        }
    }
}
