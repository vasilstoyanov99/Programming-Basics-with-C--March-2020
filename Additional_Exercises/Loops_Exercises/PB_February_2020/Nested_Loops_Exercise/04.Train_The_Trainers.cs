using System;

namespace _04.Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double judges = int.Parse(Console.ReadLine());
            string input = "";
            double totalScore = 0.00;
            double scoresCounter = 0.00;
            while ((input = Console.ReadLine()) != "Finish")
            {
                double totalCurrentScore = 0.00;
                for (int currentJudge = 0; currentJudge < judges; currentJudge++)
                {
                    double currentScore = double.Parse(Console.ReadLine());
                    totalCurrentScore += currentScore;
                    totalScore += currentScore;
                    scoresCounter++;
                }

                Console.WriteLine($"{input} - {totalCurrentScore / judges:f2}.");
            }

            if (input == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {totalScore  / scoresCounter:f2}.");
            }
        }
    }
}
