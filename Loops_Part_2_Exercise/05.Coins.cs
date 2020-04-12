using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeBy100 = change * 100;
            int changeCoinsCounter = 0;
            while (changeBy100 >= 1)
            {
                if (changeBy100 >= 200)
                {
                    changeBy100 -= 200;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 100 && changeBy100 < 200)
                {
                    changeBy100 -= 100;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 50 && changeBy100 < 100)
                {
                    changeBy100 -= 50;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 20)
                {
                    changeBy100 -= 20;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 10)
                {
                    changeBy100 -= 10;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 5)
                {
                    changeBy100 -= 5;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 2)
                {
                    changeBy100 -= 2;
                    changeCoinsCounter++;
                }
                else if (changeBy100 >= 1)
                {
                    changeBy100 -= 1;
                    changeCoinsCounter++;
                }
            }

            Console.WriteLine(changeCoinsCounter);
        }
    }
}
