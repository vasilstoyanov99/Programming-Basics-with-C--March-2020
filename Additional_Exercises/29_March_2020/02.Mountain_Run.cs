using System;

namespace _02.Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double metersGoal = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());

            double totalSecDelay = metersGoal / 50; 
            double totalTime = metersGoal * secPerMeter;
            totalTime += Math.Floor(totalSecDelay) * 30;

            if (totalTime < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordInSec:f2} seconds slower.");
            }
        }
    }
}
