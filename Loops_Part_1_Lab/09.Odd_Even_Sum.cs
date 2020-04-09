using System;

namespace _09.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < amountNumber; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                ++counter;
                if(counter % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
