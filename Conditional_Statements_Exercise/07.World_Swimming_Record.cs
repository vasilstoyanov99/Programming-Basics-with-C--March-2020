using System;

namespace _07.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double Record = double.Parse(Console.ReadLine());
            double GoalMeters = double.Parse(Console.ReadLine());
            double SecPerMeter = double.Parse(Console.ReadLine());
            double TotalTimeSlowed = 0.0;
            if (GoalMeters >= 15)
            {
                double TimesSlowed = GoalMeters / 15;
                TotalTimeSlowed = Math.Floor(TimesSlowed) * 12.5;
            }
            double IvanTime = (GoalMeters * SecPerMeter) + TotalTimeSlowed;
            if(IvanTime < Record)
                Console.WriteLine($" Yes, he succeeded! The new world record is {IvanTime:f2} seconds.");
            else if (IvanTime >= Record)
            {
                double NeededTime = IvanTime - Record;
                Console.WriteLine($"No, he failed! He was {NeededTime:f2} seconds slower.");
                
            }
        }
    }
}
