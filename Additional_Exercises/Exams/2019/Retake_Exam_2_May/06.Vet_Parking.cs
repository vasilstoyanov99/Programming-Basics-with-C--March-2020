using System;

namespace _06.Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());
            double totalFee = 0.00;

            for (int cuurentDay = 1; cuurentDay <= days ; cuurentDay++)
            {
                double feeForTheDay = 0.00;

                for (int currentHour = 1; currentHour <= hoursPerDay; currentHour++)
                {
                    if (cuurentDay % 2 == 0 && currentHour % 2 != 0)
                    {
                        feeForTheDay += 2.50;
                    }
                    else if (cuurentDay % 2 != 0 && currentHour % 2 == 0)
                    {
                        feeForTheDay += 1.25;
                    }
                    else
                    {
                        feeForTheDay += 1.00;
                    }
                }

                Console.WriteLine($"Day: {cuurentDay} - {feeForTheDay:f2} leva");
                totalFee += feeForTheDay;
            }

            Console.WriteLine($"Total: {totalFee:f2} leva");
        }
    }
}
