using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double Bonus1 = 0.0;
            if (num <= 100)
                Bonus1 += 5;
            else if (num > 100 && num <= 1000)
                Bonus1 += num * 0.20;
            else if (num > 1000)
                Bonus1 += num * 0.10;
            if (num % 2 == 0)
                Bonus1 += 1.0;
            else if (num % 10 == 5)
                Bonus1 += 2.0;
            double Summed = num + Bonus1;
            Console.WriteLine($"{Bonus1}");
            Console.WriteLine($"{Summed}");
        }
    }
}
