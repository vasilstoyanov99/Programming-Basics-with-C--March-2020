using System;

namespace _06.Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tounamentName = Console.ReadLine();
            int wonPlaysCounter = 0;
            int lostPlaysCounter = 0;
            int totalPlays = 0;

            while (tounamentName != "End of tournaments")
            {
                int numOfPlays = int.Parse(Console.ReadLine());
                totalPlays += numOfPlays;

                for (int currentPlay = 1; currentPlay <= numOfPlays; currentPlay++)
                {
                    int pointsFromDesiTeam = int.Parse(Console.ReadLine());
                    int pointsFromOpponetsTeam = int.Parse(Console.ReadLine());

                    if (pointsFromDesiTeam > pointsFromOpponetsTeam)
                    {
                        Console.WriteLine($"Game {currentPlay} of tournament {tounamentName}: win with {pointsFromDesiTeam - pointsFromOpponetsTeam} points.");
                        wonPlaysCounter++;
                    }
                    else if (pointsFromDesiTeam < pointsFromOpponetsTeam)
                    {
                        Console.WriteLine($"Game {currentPlay} of tournament {tounamentName}: lost with {pointsFromOpponetsTeam - pointsFromDesiTeam} points.");
                        lostPlaysCounter++;
                    }
                }

                tounamentName = Console.ReadLine();
            }

            double perWonPlays = (wonPlaysCounter * 1.0 / totalPlays) * 100;
            double perLostPlays = (lostPlaysCounter * 1.0 / totalPlays) * 100;

            Console.WriteLine($"{perWonPlays:f2}% matches win");
            Console.WriteLine($"{perLostPlays:f2}% matches lost");
        }
    }
}
