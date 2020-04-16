using System;

namespace _05.Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeamName = Console.ReadLine();
            int playedMatches = int.Parse(Console.ReadLine());
            int totalTeamPoints = 0;
            int wonGanes = 0;
            int Ties = 0;
            int lostGames = 0;

            if (playedMatches <= 0)
            {
                Console.WriteLine($"{footballTeamName} hasn't played any games during this season.");
                return;
            }

            for (int currentMatch = 1; currentMatch <=  playedMatches; currentMatch++)
            {
                string matchResult = Console.ReadLine();

                switch (matchResult)
                {
                    case "W":
                        totalTeamPoints += 3;
                        wonGanes++;
                        break;
                    case "D":
                        totalTeamPoints += 1;
                        Ties++;
                        break;
                    case "L":
                        lostGames++;
                        break;
                }
            }

            Console.WriteLine($"{footballTeamName} has won {totalTeamPoints} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wonGanes}");
            Console.WriteLine($"## D: {Ties}");
            Console.WriteLine($"## L: {lostGames}");
            Console.WriteLine($"Win rate: {wonGanes * 1.0 / playedMatches * 100:f2}%");
        }
    }
}
