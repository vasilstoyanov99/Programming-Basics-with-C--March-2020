using System;

namespace _04.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            double numGroups = double.Parse(Console.ReadLine());
            double totalClimbers = 0.00;
            double musalaTotalClimbers = 0.00;
            double monblanTotalClimbers = 0.00;
            double kilimanjaroTotalClimbers = 0.00;
            double K2TotalClimbers = 0.00;
            double everestTotalClimbers = 0.00;
            for (int currentGroup = 1; currentGroup <= numGroups; currentGroup++)
            {
                double currentGroupMembers = double.Parse(Console.ReadLine());
                totalClimbers += currentGroupMembers;

                if (currentGroupMembers <= 5)
                {
                    musalaTotalClimbers += currentGroupMembers;
                }
                else if (currentGroupMembers >= 6 && currentGroupMembers <= 12)
                {
                    monblanTotalClimbers += currentGroupMembers;
                }
                else if (currentGroupMembers >= 13 && currentGroupMembers <= 25)
                {
                    kilimanjaroTotalClimbers += currentGroupMembers;
                }
                else if (currentGroupMembers >= 26 && currentGroupMembers <= 40)
                {
                    K2TotalClimbers += currentGroupMembers;
                }
                else if (currentGroupMembers >= 41)
                {
                    everestTotalClimbers += currentGroupMembers;
                }
            }

            Console.WriteLine($"{(musalaTotalClimbers / totalClimbers) * 100:f2}%");
            Console.WriteLine($"{(monblanTotalClimbers / totalClimbers) * 100:f2}%");
            Console.WriteLine($"{(kilimanjaroTotalClimbers / totalClimbers) * 100:f2}%");
            Console.WriteLine($"{(K2TotalClimbers / totalClimbers) * 100:f2}%");
            Console.WriteLine($"{(everestTotalClimbers / totalClimbers) * 100:f2}%");
        }
    }
}
