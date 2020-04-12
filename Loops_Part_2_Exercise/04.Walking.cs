using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalSteps = 10000;
            int totalSteps = 0;

            while (totalSteps < goalSteps)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int goingHomeSteps = int.Parse(Console.ReadLine());
                    totalSteps += goingHomeSteps;
                    break;
                }
                else
                {
                    int currentSteps = int.Parse(input);
                    totalSteps += currentSteps;
                } 
            }

            if (totalSteps >= goalSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{goalSteps - totalSteps} more steps to reach goal.");
            }
        }
    }
}
