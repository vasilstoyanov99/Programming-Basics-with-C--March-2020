using System;

namespace _05.Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int p1Counter = 0;
            int p2Counter = 0;
            int p3Counter = 0;

            for (int currentNumber = 1; currentNumber <= nNumbers; currentNumber++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1Counter++;
                }
                if (number % 3 == 0)
                {
                    p2Counter++;
                }
                if (number % 4 == 0)
                {
                    p3Counter++;
                }
            }
            double p1Percent = (p1Counter * 1.00 / nNumbers) * 100;
            double p2Percent = (p2Counter * 1.00 / nNumbers) * 100;
            double p3Percent = (p3Counter * 1.00 / nNumbers) * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
        }
    }
}
