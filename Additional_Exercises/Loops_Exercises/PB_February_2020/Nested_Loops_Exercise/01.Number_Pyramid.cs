using System;

namespace _01.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCounter = 0;
            for (int row = 1; row <= n; row++)
            {
                for (int numberOnRow = 1; numberOnRow <= row; numberOnRow++)
                {
                    numCounter++;
                    Console.Write($"{numCounter} ");

                    if (numCounter == n)
                    {
                        break;
                    }
                }

                Console.WriteLine("");

                if (numCounter == n)
                {
                    break;
                }
            }
        }
    }
}
