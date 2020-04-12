using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeW = int.Parse(Console.ReadLine());
            int cakeL = int.Parse(Console.ReadLine());
            int totalCakeSize = cakeW * cakeL;
            bool isStoped = false;
            while (totalCakeSize > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    isStoped = true;
                    break;
                }
                else
                {
                    int currentTakenPices = int.Parse(input);
                    totalCakeSize -= currentTakenPices;
                }
                
            }

            if (isStoped)
            {
                Console.WriteLine($"{totalCakeSize} pieces are left." );
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalCakeSize)} pieces more.");
            }
        }
    }
}
