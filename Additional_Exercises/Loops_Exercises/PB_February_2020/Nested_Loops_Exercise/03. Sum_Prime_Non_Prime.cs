using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int primeNumSum = 0;
            int nonPrimeNumSum = 0;
            while ((input = Console.ReadLine()) != "stop" )
            {
                int currentNumber = int.Parse(input);
                bool isPrime = true;
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int Pow = 2; Pow <= Math.Sqrt(currentNumber); Pow++)
                {
                    if (currentNumber % Pow == 0)
                    {
                        isPrime = false;
                    }
                }

                if (!isPrime)
                {
                    nonPrimeNumSum += currentNumber;
                }

                else
                {
                    primeNumSum += currentNumber;
                }
             
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumSum}");
        }
    }
}
