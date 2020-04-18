using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int DaysOff = int.Parse(Console.ReadLine());
            int WorkDaysPlay = (365 - DaysOff) * 63;
            int DaysOffPlay = DaysOff * 127;
            int TotalMinPlay = WorkDaysPlay + DaysOffPlay;

            if (TotalMinPlay <= 30000)
            {
                int LeftMin = 30000 - TotalMinPlay;
                Console.WriteLine("Tom sleeps well");

                if (LeftMin < 60)
                {
                    Console.WriteLine($"0 hours and {LeftMin} minutes less for play");
                }
                else if (LeftMin == 60 )
                {
                    Console.WriteLine("1 hours and 0 minutes less for play");
                }
                else if (LeftMin > 60)
                {
                    var timeSpan = TimeSpan.FromMinutes(LeftMin);
                    int mm = timeSpan.Minutes;
                    double hh = LeftMin / 60;
                    Console.WriteLine($"{Math.Truncate(hh)} hours and {mm} minutes less for play");
                }
            }
            else if (TotalMinPlay > 30000)
            {
                Console.WriteLine("Tom will run away");

                int LeftMin = TotalMinPlay - 30000;

                if (LeftMin < 60)
                {
                    Console.WriteLine($"0 hours and {LeftMin} minutes more for play");
                }
                else if (LeftMin == 60)
                {
                    Console.WriteLine("1 hours and 0 minutes more for play");
                }
                else if (LeftMin > 60)
                {
                    var timeSpan = TimeSpan.FromMinutes(LeftMin);
                    int mm = timeSpan.Minutes;
                    double hh = LeftMin / 60;
                    Console.WriteLine($"{Math.Truncate(hh)} hours and {mm} minutes more for play");
                }
            }
        }
    }
}
