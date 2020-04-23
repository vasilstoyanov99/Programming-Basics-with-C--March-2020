using System;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minGoal = int.Parse(Console.ReadLine());
            int secGoal = int.Parse(Console.ReadLine());
            double goalLenghtInMeters = double.Parse(Console.ReadLine());
            double secPer100Meters = double.Parse(Console.ReadLine());

            int totalSecGoal = (minGoal * 60) + secGoal;
            double timeSlowed = (goalLenghtInMeters / 120) * 2.5;
            double totalMartinsTime = ((goalLenghtInMeters / 100) * secPer100Meters) - timeSlowed;

            if (totalMartinsTime <= totalSecGoal)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalMartinsTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(totalMartinsTime - totalSecGoal):f3} second slower.");
            }
            
        }
    }
}
