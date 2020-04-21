using System;

namespace _05.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int playedTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int pointsFromTournaments = 0;
            int winsCount = 0;
            int finalsCount = 0;
            int semiFinalsCount = 0;

            for (int currentTournament = 1; currentTournament <= playedTournaments; currentTournament++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    pointsFromTournaments += 2000;
                    winsCount++;
                }
                else if (result == "F")
                {
                    pointsFromTournaments += 1200;
                    finalsCount++;
                }
                else if (result == "SF")
                {
                    pointsFromTournaments += 720;
                    semiFinalsCount++;
                }
            }

            int totalPoints = startingPoints + pointsFromTournaments;
            double avrPoints = pointsFromTournaments * 1.0 / playedTournaments;
            double perWonTournaments = winsCount * 1.0 / playedTournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(avrPoints)}");
            Console.WriteLine($"{perWonTournaments:f2}%");
        }
    }
}
