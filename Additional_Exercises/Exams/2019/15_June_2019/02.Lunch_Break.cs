using System;

namespace _02.Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            double episodeTimeLenght = double.Parse(Console.ReadLine());
            double lunchBreakLenght = double.Parse(Console.ReadLine());

            double timeForEating = lunchBreakLenght * 1.0 * 1 / 8;
            double timeForChill = lunchBreakLenght * 1 / 4;
            double totalUsedForBreakTime = timeForEating + timeForChill;
            double leftTimeForWatching = lunchBreakLenght - totalUsedForBreakTime;

            if (leftTimeForWatching >= episodeTimeLenght)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(leftTimeForWatching - episodeTimeLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeTimeLenght - leftTimeForWatching)} more minutes.");
            }
        }
    }
}
