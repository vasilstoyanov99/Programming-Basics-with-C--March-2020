using System;

namespace _02.Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minWalkingPerWalk = int.Parse(Console.ReadLine());
            int numWalkPerDay = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());
            int neededCalToBurn = caloriesPerDay / 2;
            int totalBurntCalories = minWalkingPerWalk * numWalkPerDay * 5;

            if (totalBurntCalories >= neededCalToBurn)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalBurntCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalBurntCalories}.");
            }
        }
    }
}
