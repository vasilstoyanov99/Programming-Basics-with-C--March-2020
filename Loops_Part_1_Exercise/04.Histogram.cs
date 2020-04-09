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
            double p4Count = 0;
            double p5Count = 0;
            for (int i = 0; i < amountNumbers; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1Count++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    p2Count++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    p3Count++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    p4Count++;
                }
                else if (currentNumber >= 800)
                {
                    p5Count++;
                }

            }

            Console.WriteLine($"{p1Count / amountNumbers * 100:f2}%");
            Console.WriteLine($"{p2Count / amountNumbers * 100:f2}%");
            Console.WriteLine($"{p3Count / amountNumbers * 100:f2}%");
            Console.WriteLine($"{p4Count / amountNumbers * 100:f2}%");
            Console.WriteLine($"{p5Count / amountNumbers * 100:f2}%");

        }
    }
}
