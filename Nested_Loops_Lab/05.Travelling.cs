using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double wantedBudget = double.Parse(Console.ReadLine());

                while (wantedBudget > 0)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    wantedBudget -= savedMoney;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
