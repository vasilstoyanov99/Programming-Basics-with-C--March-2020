using System;

namespace _06.Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaciNum = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string winnerName = "";

            for (int currentKozunac = 0; currentKozunac < kozunaciNum; currentKozunac++)
            {
                string bakerName = Console.ReadLine();
                int bakerScore = 0;
                string input = Console.ReadLine();

                while (input != "Stop")
                {
                    int score = int.Parse(input);
                    bakerScore += score;
                    input = Console.ReadLine();
                }

                Console.WriteLine($"{bakerName} has {bakerScore} points.");

                if (maxPoints < bakerScore)
                {
                    Console.WriteLine($"{bakerName} is the new number 1!");
                    maxPoints = bakerScore;
                    winnerName = bakerName;
                }
            }

            Console.WriteLine($"{winnerName} won competition with {maxPoints} points!");
        }
    }
}
