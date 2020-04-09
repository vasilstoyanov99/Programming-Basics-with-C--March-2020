using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountNumbers = double.Parse(Console.ReadLine());
            double p1Count = 0;
            double p2Count = 0;
            double p3Count = 0;
            for (int i = 0; i < amountNumbers; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    p1Count++;
                }
                if (currentNumber % 3 == 0)
                {
                    p2Count++;
                }
                if (currentNumber % 4 == 0)
                {
                    p3Count++;
                }
            }

            Console.WriteLine($"{p1Count / amountNumbers * 100:f2}%");
            Console.WriteLine($"{p2Count / amountNumbers * 100:f2}%");
            Console.WriteLine($"{p3Count / amountNumbers * 100:f2}%");            
        }
    }
}
