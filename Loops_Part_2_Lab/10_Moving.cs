using System;

namespace _10Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int totalSpace = W * H * L;
            string input = Console.ReadLine();

            while (input != "Done")
            {

                int numBoxes = int.Parse(input);
                totalSpace -= numBoxes;

                if (totalSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalSpace)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                Console.WriteLine($"{totalSpace} Cubic meters left.");
            }
        }
    }
}
