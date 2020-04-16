using System;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            double perToNotPaint = double.Parse(Console.ReadLine());
            string paintLiters = Console.ReadLine();
            double totalWallsAreaToPaint = (wallHight * wallWidth) * 4;
            perToNotPaint = (totalWallsAreaToPaint * perToNotPaint) / 100;
            totalWallsAreaToPaint -= perToNotPaint;
            totalWallsAreaToPaint = Math.Ceiling(totalWallsAreaToPaint);
            int litersPainted = 0;

            while (paintLiters != "Tired!")
            {
                int paintLitersInt = int.Parse(paintLiters);
                litersPainted += paintLitersInt;

                if (litersPainted > totalWallsAreaToPaint)
                {
                    Console.WriteLine($"All walls are painted and you have {litersPainted - totalWallsAreaToPaint} l paint left!" );
                    break;
                }

                if (litersPainted == totalWallsAreaToPaint)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }

                paintLiters = Console.ReadLine();
            }

            if (paintLiters == "Tired!")
            {
                Console.WriteLine($"{totalWallsAreaToPaint - litersPainted} quadratic m left.");
            }
        }
    }
}
