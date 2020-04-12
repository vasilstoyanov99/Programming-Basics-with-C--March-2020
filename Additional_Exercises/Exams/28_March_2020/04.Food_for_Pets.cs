using System;

namespace _04.Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double totalEatenFood = 0.00;
            double totalEatenFoodDog = 0.00;
            double totalEatenFoodCat = 0.00;
            double totalCookies = 0.00;
            for (int currentDay = 1; currentDay <= numDays; currentDay++)
            {
                double totalFoodForTheDay = 0.00;
                double foodEatenByDog = double.Parse(Console.ReadLine());
                double foodEatenByCat = double.Parse(Console.ReadLine());
                totalFoodForTheDay += foodEatenByCat + foodEatenByDog;
                totalEatenFood += totalFoodForTheDay;
                totalEatenFoodDog += foodEatenByDog;
                totalEatenFoodCat += foodEatenByCat;

                if (currentDay % 3 == 0)
                {
                    totalCookies += totalFoodForTheDay * 0.10;
                }
            }
            double perEatenFood = (totalEatenFood / totalFood) * 100; 
            double perEatenFoodDog = (totalEatenFoodDog / totalEatenFood) * 100; 
            double perEatenFoodCat = (totalEatenFoodCat / totalEatenFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalCookies)}gr.");
            Console.WriteLine($"{perEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{perEatenFoodDog:f2}% eaten from the dog.");
            Console.WriteLine($"{perEatenFoodCat:f2}% eaten from the cat.");
        }
    }
}
