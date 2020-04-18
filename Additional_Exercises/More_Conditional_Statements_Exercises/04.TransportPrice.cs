using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int KM = int.Parse(Console.ReadLine());
            string TypeOfDay = Console.ReadLine().ToLower();

            if (KM >= 20 && KM < 100)
            {
                double Price = KM * 0.09;
                Console.WriteLine($"{Price:f2}");
            }
            else if (KM >= 100)
            {
                double Price = KM * 0.06;
                Console.WriteLine($"{Price:f2}");
            }
            else
            {
                if (TypeOfDay == "day")
                {
                    double Price = KM * 0.79 + 0.70;
                    Console.WriteLine($"{Price:f2}");
                }
                else if (TypeOfDay == "night")
                {
                    double Price = KM * 0.90 + 0.70;
                    Console.WriteLine($"{Price:f2}");
                }
            }
                

        }
    }
}
