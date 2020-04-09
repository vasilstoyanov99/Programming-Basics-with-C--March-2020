using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0.00;
            int numSeats = r * c;
            switch (type)
            {
                case "Premiere":
                    price += 12.00;
                    break;
                case "Normal":
                    price += 7.50;
                    break;
                case "Discount":
                    price += 5.00;
                    break;
            }
            Console.WriteLine($"{price * numSeats * 1.00:f2} leva");
        }
    }
}
