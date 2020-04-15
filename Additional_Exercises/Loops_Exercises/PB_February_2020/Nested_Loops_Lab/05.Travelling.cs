using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savaedMoney = 0;
                while (savaedMoney < budget)
                {
                    double savedForTheDay = double.Parse(Console.ReadLine());
                    savaedMoney += savedForTheDay;
                }
                if (savaedMoney >= budget)
                {
                    Console.WriteLine($"Going to {input}!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
