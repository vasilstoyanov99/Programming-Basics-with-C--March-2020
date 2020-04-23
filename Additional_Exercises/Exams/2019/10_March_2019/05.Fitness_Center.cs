using System;

namespace _05.Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int numClients = int.Parse(Console.ReadLine());
            int BackExerciseCounter = 0;
            int ChestExerciseCounter = 0;
            int LegsExerciseCounter = 0;
            int AbsExerciseCounter = 0;
            int boughtProteinShakesCounter = 0;
            int boughtProteinBarsCounter = 0;
            int totalClientsExercisingCounter = 0;

            for (int currentClient = 0; currentClient < numClients; currentClient++)
            {
                string typeActivity = Console.ReadLine();

                switch (typeActivity)
                {
                    case "Back":
                        BackExerciseCounter++;
                        totalClientsExercisingCounter++;
                        break;
                    case "Chest":
                        ChestExerciseCounter++;
                        totalClientsExercisingCounter++;
                        break;
                    case "Legs":
                        LegsExerciseCounter++;
                        totalClientsExercisingCounter++;
                        break;
                    case "Abs":
                        AbsExerciseCounter++;
                        totalClientsExercisingCounter++;
                        break;
                    case "Protein shake":
                        boughtProteinShakesCounter++;
                        break;
                    case "Protein bar":
                        boughtProteinBarsCounter++;
                        break;
                }
            }

            int totalClientsForProtein = boughtProteinBarsCounter + boughtProteinShakesCounter;

            Console.WriteLine($"{BackExerciseCounter} - back");
            Console.WriteLine($"{ChestExerciseCounter} - chest");
            Console.WriteLine($"{LegsExerciseCounter} - legs");
            Console.WriteLine($"{AbsExerciseCounter} - abs");
            Console.WriteLine($"{boughtProteinShakesCounter} - protein shake");
            Console.WriteLine($"{boughtProteinBarsCounter} - protein bar");
            Console.WriteLine($"{(totalClientsExercisingCounter * 1.0 / numClients) * 100 :f2}% - work out");
            Console.WriteLine($"{(totalClientsForProtein * 1.0 / numClients) * 100 :f2}% - protein");
        }
    }
}
