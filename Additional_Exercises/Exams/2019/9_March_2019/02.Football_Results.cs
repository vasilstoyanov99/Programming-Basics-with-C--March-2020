using System;

namespace _02.Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayResults = Console.ReadLine();
            string secondPlayResults = Console.ReadLine();
            string thirdPlayResults = Console.ReadLine();
            int wonCount = 0;
            int tieCount = 0;
            int lostCount = 0;

            int firstPlayTeamOneResult = int.Parse(firstPlayResults[0].ToString());
            int firstPlayTeamTwoResult = int.Parse(firstPlayResults[2].ToString());

            if (firstPlayTeamOneResult > firstPlayTeamTwoResult)
            {
                wonCount++;
            }
            else if (firstPlayTeamOneResult < firstPlayTeamTwoResult)
            {
                lostCount++;
            }
            else if (firstPlayTeamOneResult == firstPlayTeamTwoResult)
            {
                tieCount++;
            }

            int secondPlayTeamOneResult = int.Parse(secondPlayResults[0].ToString());
            int secondPlayTeamTwoResult = int.Parse(secondPlayResults[2].ToString());

            if (secondPlayTeamOneResult > secondPlayTeamTwoResult)
            {
                wonCount++;
            }
            else if (secondPlayTeamOneResult < secondPlayTeamTwoResult)
            {
                lostCount++;
            }
            else if (secondPlayTeamOneResult == secondPlayTeamTwoResult)
            {
                tieCount++;
            }

            int thirdPlayTeamOneResult = int.Parse(thirdPlayResults[0].ToString());
            int thirdPlayTeamTwoResult = int.Parse(thirdPlayResults[2].ToString());

            if (thirdPlayTeamOneResult > thirdPlayTeamTwoResult)
            {
                wonCount++;
            }
            else if (thirdPlayTeamOneResult < thirdPlayTeamTwoResult)
            {
                lostCount++;
            }
            else if (thirdPlayTeamOneResult == thirdPlayTeamTwoResult)
            {
                tieCount++;
            }

            Console.WriteLine($"Team won {wonCount} games.");
            Console.WriteLine($"Team lost {lostCount} games.");
            Console.WriteLine($"Drawn games: {tieCount}");
        }
    }
}
