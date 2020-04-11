using System;

namespace _05.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDeposits = int.Parse(Console.ReadLine());
            double balance = 0.00;

            for (int currentDeposit = 0; currentDeposit < numDeposits; currentDeposit++)
            {
                double currDeposit = double.Parse(Console.ReadLine());

                if (currDeposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                else
                {
                    Console.WriteLine($"Increase: {currDeposit:f2}");
                    balance += currDeposit;
                }
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
