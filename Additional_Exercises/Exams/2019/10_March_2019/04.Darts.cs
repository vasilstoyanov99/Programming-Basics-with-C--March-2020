using System;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string input = "";
            int successfulShots = 0;
            int unSuccessfulShots = 0;
            int startPoints = 301;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string typeShot = input;
                int points = int.Parse(Console.ReadLine());

                if (typeShot == "Single")
                {
                    if (points > startPoints)
                    {
                        unSuccessfulShots++;
                        continue;
                    }
                    else
                    {
                        startPoints -= points;
                        successfulShots++;
                    }
                    
                }
                else if (typeShot == "Double")
                {
                    points *= 2;

                    if (points > startPoints)
                    {
                        unSuccessfulShots++;
                        continue;
                    }
                    else
                    {
                        startPoints -= points;
                        successfulShots++;
                    }
                    
                }
                else if (typeShot == "Triple")
                {
                    points *= 3;

                    if (points > startPoints)
                    {
                        unSuccessfulShots++;
                        continue;
                    }
                    else
                    {
                        startPoints -= points;
                        successfulShots++;
                    }
                }

                if (startPoints <= 0)
                {
                    break;
                }

            }

            if (input == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {unSuccessfulShots} unsuccessful shots.");
            }
            else if (startPoints <= 0)
            {
                Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
            }
        }
    }
}
