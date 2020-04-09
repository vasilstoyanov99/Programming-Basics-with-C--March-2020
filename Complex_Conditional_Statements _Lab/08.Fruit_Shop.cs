using System;

namespace _08.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Type = Console.ReadLine().ToLower();
            string Day = Console.ReadLine();
            double Quantity = double.Parse(Console.ReadLine());
            double Price = 0.00;
            bool isTrue = true;
            switch (Day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (Type)
                    {
                        case "banana":
                            Price += 2.50;
                            break;
                        case "apple":
                            Price += 1.20;
                            break;
                        case "orange":
                            Price += 0.85;
                            break;
                        case "grapefruit":
                            Price += 1.45;
                            break;
                        case "kiwi":
                            Price += 2.70;
                            break;
                        case "pineapple":
                            Price += 5.50;
                            break;
                        case "grapes":
                            Price += 3.85;
                            break;
                        default:
                            isTrue = false;
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (Type)
                    {
                        case "banana":
                            Price += 2.70;
                            break;
                        case "apple":
                            Price += 1.25;
                            break;
                        case "orange":
                            Price += 0.90;
                            break;
                        case "grapefruit":
                            Price += 1.60;
                            break;
                        case "kiwi":
                            Price += 3.00;
                            break;
                        case "pineapple":
                            Price += 5.60;
                            break;
                        case "grapes":
                            Price += 4.20;
                            break;
                        default:
                            isTrue = false;
                            break;
                    }
                    break;
                default:
                    isTrue = false;
                    break;
            }
            if(isTrue)
                Console.WriteLine($"{Price * Quantity:f2}");
           else if (!isTrue)
                Console.WriteLine("error");
        }
    }
}
