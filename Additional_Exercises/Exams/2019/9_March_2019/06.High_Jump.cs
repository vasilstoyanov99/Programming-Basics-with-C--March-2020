
using System;

namespace _06.High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int hightGoal = int.Parse(Console.ReadLine());
            int startHight = hightGoal - 30;
            int jumpsCount = 0;
            int failedJumpsCount = 0;
            bool isGoalAchieved = false;
            int lastHight = 0;

            while (failedJumpsCount < 3)
            {
                int currentJumpResult = int.Parse(Console.ReadLine());

                for (int currentTry = 1; currentTry <= 3; currentTry++)
                {
                    jumpsCount++;

                    if (currentJumpResult > hightGoal)
                    {
                        isGoalAchieved = true;
                        break;
                    }

                    if (currentJumpResult > startHight)
                    {
                        lastHight = startHight;
                        startHight += 5;
                        failedJumpsCount = 0;
                        break;
                    }
                    else if (currentJumpResult <= startHight)
                    {
                        failedJumpsCount++;
                        lastHight = startHight;
                    }

                    if (currentTry < 3)
                    {
                        currentJumpResult = int.Parse(Console.ReadLine());
                    }

                }

                if (isGoalAchieved)
                {
                    break;
                }
            }

            if (!isGoalAchieved)
            {
                Console.WriteLine($"Tihomir failed at {lastHight}cm after {jumpsCount} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {lastHight}cm after {jumpsCount} jumps.");
            }
        }
    }
}
