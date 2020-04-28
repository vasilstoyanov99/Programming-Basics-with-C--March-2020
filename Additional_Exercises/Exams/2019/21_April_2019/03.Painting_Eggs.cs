using System;

namespace _03.Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string typeOfColour = Console.ReadLine();
            int eggsPacksNum = int.Parse(Console.ReadLine());
            int singlePackPrice = 0;

            if (typeOfColour == "Red")
            {
                switch (eggsSize)
                {
                    case "Large":
                        singlePackPrice = 16;
                        break;
                    case "Medium":
                        singlePackPrice = 13;
                        break;
                    case "Small":
                        singlePackPrice = 9;
                        break;
                }
            }
            else if (typeOfColour == "Green")
            {
                switch (eggsSize)
                {
                    case "Large":
                        singlePackPrice = 12;
                        break;
                    case "Medium":
                        singlePackPrice = 9;
                        break;
                    case "Small":
                        singlePackPrice = 8;
                        break;
                }
            }
            else if (typeOfColour == "Yellow")
            {
                switch (eggsSize)
                {
                    case "Large":
                        singlePackPrice = 9;
                        break;
                    case "Medium":
                        singlePackPrice = 7;
                        break;
                    case "Small":
                        singlePackPrice = 5;
                        break;
                }
            }

            double totalPrice = eggsPacksNum * singlePackPrice;
            double productionCosts = totalPrice * 0.35;
            totalPrice -= productionCosts;
            Console.WriteLine($"{totalPrice:f2} leva.");
        }
    }
}
