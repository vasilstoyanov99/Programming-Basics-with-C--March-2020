using System;

namespace _01.Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBTC = int.Parse(Console.ReadLine());
            double numChineseYoans = double.Parse(Console.ReadLine());
            double comminsionPercentage = double.Parse(Console.ReadLine());

            double EURfromBTC = (numBTC * 1168) / 1.95;
            double ChinYoansToUSD = numChineseYoans * 0.15;
            double ChinYoansUSDtoEUR = (ChinYoansToUSD * 1.76) / 1.95;
            double EUR = ChinYoansUSDtoEUR + EURfromBTC;
            double EURCommision = EUR * comminsionPercentage / 100;
            double totalEUR = EUR - EURCommision; 

            Console.WriteLine($"{totalEUR:f2}");
        }
    }
}
