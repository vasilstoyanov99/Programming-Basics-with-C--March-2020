using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int NeededHours = int.Parse(Console.ReadLine());
            int DaysForWork = int.Parse(Console.ReadLine());
            int OvertimeWorkers = int.Parse(Console.ReadLine());

            double DaysForTraining = DaysForWork * 0.10;
            double DaysLeftToWork = DaysForWork - DaysForTraining;
            double OverTime = DaysForWork * OvertimeWorkers * 2;
            double RealHoursWork = DaysLeftToWork * 8;
            double TotalWorkHours = OverTime + RealHoursWork;

            if (TotalWorkHours > NeededHours)
            {
                double LeftHours = TotalWorkHours - NeededHours;
                Console.WriteLine($"Yes!{Math.Truncate(LeftHours)} hours left.");
            }
            else if (NeededHours > TotalWorkHours)
            {
                double NeedeMoreHours = NeededHours - TotalWorkHours;
                Console.WriteLine($"Not enough time!{Math.Truncate(NeedeMoreHours)} hours needed.");
            }
        }
    }
}
