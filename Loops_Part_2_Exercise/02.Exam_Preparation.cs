using System;

namespace _02.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBadMarks = int.Parse(Console.ReadLine());
            int totalBadMarks = 0;
            double tasksCounter = 0.00;
            double totalScore = 0.00;
            string currentTask = "";
            bool IsEnough = false;

            while (!IsEnough)
            {
                string input = Console.ReadLine();
                if (input == "Enough")
                {
                    IsEnough = true;
                    break;
                }
                double currentMark = double.Parse(Console.ReadLine());
                currentTask = input;
                tasksCounter++;
                totalScore += currentMark;

                if (currentMark <= 4.00)
                {
                    totalBadMarks++;
                }

                if (totalBadMarks == numBadMarks)
                {
                    Console.WriteLine($"You need a break, {totalBadMarks} poor grades.");
                    break;
                }

            }

            if (IsEnough)
            {
                Console.WriteLine($"Average score: {totalScore / tasksCounter:f2}");
                Console.WriteLine($"Number of problems: {tasksCounter}");
                Console.WriteLine($"Last problem: {currentTask}");
            }
        }
    }
}
