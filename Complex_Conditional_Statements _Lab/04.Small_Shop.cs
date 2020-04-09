using System;

namespace _04.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Product = Console.ReadLine().ToLower();
            string Town = Console.ReadLine();
            double Quantity = double.Parse(Console.ReadLine());
            double Price = 0;
            if(Town == "Sofia")
            {
                if (Product == "coffee")
                    Price += 0.50;
                else if (Product == "water")
                    Price += 0.80;
                else if (Product == "beer")
                    Price += 1.20;
                else if (Product == "sweets")
                    Price += 1.45;
                else if (Product == "peanuts")
                    Price += 1.60;
            }
           else if (Town == "Plovdiv")
            {
                if (Product == "coffee")
                    Price += 0.40;
                else if (Product == "water")
                    Price += 0.70;
                else if (Product == "beer")
                    Price += 1.15;
                else if (Product == "sweets")
                    Price += 1.30;
                else if (Product == "peanuts")
                    Price += 1.50;
            }
            else if (Town == "Varna")
            {
                if (Product == "coffee")
                    Price += 0.45;
                else if (Product == "water")
                    Price += 0.70;
                else if (Product == "beer")
                    Price += 1.10;
                else if (Product == "sweets")
                    Price += 1.35;
                else if (Product == "peanuts")
                    Price += 1.55;
            }
            Console.WriteLine($"{Quantity * Price:f2}");
        }
    }
}
