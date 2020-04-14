using System;

namespace _03.Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeBeverage = Console.ReadLine();
            string choiceOfSugar = Console.ReadLine();
            double numBeverages = double.Parse(Console.ReadLine());
            double pricePerBeverage = 0.00;
            double totalPrice = 0.00;
            if (typeBeverage == "Espresso")
            {
                switch (choiceOfSugar)
                {
                    case "Without":
                        pricePerBeverage = 0.90 * 0.65;
                        break;
                    case "Normal":
                        pricePerBeverage = 1.00;
                        break;
                    case "Extra":
                        pricePerBeverage = 1.20;
                        break;
                }

            }

           else if (typeBeverage == "Cappuccino")
            {
                switch (choiceOfSugar)
                {
                    case "Without":
                        pricePerBeverage = 1.00 * 0.65;
                        break;
                    case "Normal":
                        pricePerBeverage = 1.20;
                        break;
                    case "Extra":
                        pricePerBeverage = 1.60;
                        break;
                }

            }

            else if (typeBeverage == "Tea")
            {
                switch (choiceOfSugar)
                {
                    case "Without":
                        pricePerBeverage = 0.50 * 0.65;
                        break;
                    case "Normal":
                        pricePerBeverage = 0.60;
                        break;
                    case "Extra":
                        pricePerBeverage = 0.70;
                        break;
                }

            }

            totalPrice = pricePerBeverage * numBeverages;
            if (numBeverages >= 5 && typeBeverage == "Espresso")
            {
                totalPrice *= 0.75;
            }

            if (totalPrice > 15.00)
            {
                totalPrice *= 0.80;
            }

            Console.WriteLine($"You bought {Math.Truncate(numBeverages)} cups of {typeBeverage} for {totalPrice:f2} lv.");
        }
    }
}
