using System;

namespace _02.Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string TypeOfAnimal = Console.ReadLine().ToLower();
            string Output = "";
            switch (TypeOfAnimal)
            {
                case "dog":
                    Output = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Output = "reptile";
                    break;
                default:
                    Output = "unknown";
                    break;
            }
            Console.WriteLine(Output);
        }
    }
}
