using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine().ToLower();
            double holidaysNum = double.Parse(Console.ReadLine());
            double weekendsHome = double.Parse(Console.ReadLine());
            double totalPlays = 0.00;
            totalPlays += holidaysNum * 2/3;
            totalPlays += weekendsHome;
            double weekendSofia = 48 - weekendsHome;
            totalPlays += weekendSofia * 0.75;
            if (typeYear == "leap")
                totalPlays *= 1.15;
            Console.WriteLine($"{Math.Truncate(totalPlays)}");
        }
    }
}
