using System;

namespace _06.Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxPoints = 0;
            int counter = 0;
            string wiinerName = "";
            while (name != "Stop")
            {
                int playerPoints = 0;
                for (int cuurentLetter = 0; cuurentLetter < name.Length; cuurentLetter++)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    int currentCharAsciiNum = name[cuurentLetter];

                    if (currentNum == currentCharAsciiNum)
                    {
                        playerPoints += 10;
                    }
                    else
                    {
                        playerPoints += 2;
                    }

                }

                if (playerPoints > maxPoints)
                {
                    maxPoints = playerPoints;
                    wiinerName = name;
                }

                if (playerPoints == maxPoints)
                {
                    wiinerName = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {wiinerName} with {maxPoints} points!");
        }
    }
}
