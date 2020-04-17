using System;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearsOfSubscription = Console.ReadLine();
            string typePlan = Console.ReadLine();
            string addMobileNet = Console.ReadLine();
            int monthsOfPayment = int.Parse(Console.ReadLine());
            double planPrice = 0.00;

            if (yearsOfSubscription == "one")
            {
                switch (typePlan)
                {
                    case "Small":
                        planPrice = 9.98;
                        break;
                    case "Middle":
                        planPrice = 18.99;
                        break;
                    case "Large":
                        planPrice = 25.98;
                        break;
                    case "ExtraLarge":
                        planPrice = 35.99;
                        break;
                }
            }

            else if (yearsOfSubscription == "two")
            {
                switch (typePlan)
                {
                    case "Small":
                        planPrice = 8.58;
                        break;
                    case "Middle":
                        planPrice = 17.09;
                        break;
                    case "Large":
                        planPrice = 23.59;
                        break;
                    case "ExtraLarge":
                        planPrice = 31.79;
                        break;
                }
            }

            if (addMobileNet == "yes")
            {
                if (planPrice <= 10.00)
                {
                    planPrice += 5.50;
                }
                else if (planPrice <= 30.00)
                {
                    planPrice += 4.35;
                }
                else if (planPrice > 30.00)
                {
                    planPrice += 3.85;
                }
            }

            double totalPrice = planPrice * monthsOfPayment;

            if (yearsOfSubscription == "two")
            {
                totalPrice *= 0.9625;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
