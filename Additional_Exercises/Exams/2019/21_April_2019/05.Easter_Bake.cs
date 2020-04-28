using System;

namespace _05.Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaciNum = int.Parse(Console.ReadLine());
            int maxUsedSugar = int.MinValue;
            int maxUsedFlour = int.MinValue;
            int totalUsedSugar = 0;
            int totalUsedFlour = 0;

            for (int currentCozunac = 0; currentCozunac < kozunaciNum; currentCozunac++)
            {
                int usedSugar = int.Parse(Console.ReadLine());
                int usedFlour = int.Parse(Console.ReadLine());
                totalUsedSugar += usedSugar;
                totalUsedFlour += usedFlour;

                if (usedSugar > maxUsedSugar)
                {
                    maxUsedSugar = usedSugar;
                }

                if (usedFlour > maxUsedFlour)
                {
                    maxUsedFlour = usedFlour;
                }
            }
            double totalUsedSugarPacks = totalUsedSugar * 1.0 / 950;
            double totalUsedFlourPacks = totalUsedFlour * 1.0 / 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(totalUsedSugarPacks)}");
            Console.WriteLine($"Flour: {Math.Ceiling(totalUsedFlourPacks)}");
            Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");
        }
    }
}
