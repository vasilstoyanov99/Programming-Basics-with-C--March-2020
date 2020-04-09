using System;

namespace _03.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountNumbers = int.Parse(Console.ReadLine());
            int evenChecker = 0;
            double EvenMinNum = double.MaxValue;
            double EvenMaxNum = double.MinValue;
            double OddMinNum = double.MaxValue;
            double OddMaxNum = double.MinValue;
            double EvenSum = 0;
            double OddSum = 0;
            for (int i = 0; i < amountNumbers; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                evenChecker++;
                if(evenChecker % 2 == 0)
                {
                    EvenSum += currentNumber;
                    if(currentNumber > EvenMaxNum)
                    {
                        EvenMaxNum = currentNumber;
                       
                    }
                    if (currentNumber < EvenMinNum)
                    {
                       
                        EvenMinNum = currentNumber;
                    }
                }
                else
                {
                    OddSum += currentNumber;
                    if(currentNumber > OddMaxNum)
                    {
                       
                        OddMaxNum = currentNumber;
                    }
                    if (currentNumber < OddMinNum)
                    {
                        
                        OddMinNum = currentNumber;
                    }
                }
            }

                Console.WriteLine($"OddSum={OddSum:f2},");
            if (OddMinNum == double.MaxValue)
                Console.WriteLine($"OddMin=No,");
            else
            Console.WriteLine($"OddMin={OddMinNum:f2},");
            if (OddMaxNum == double.MinValue)
                Console.WriteLine($"OddMax=No,");
            else
            Console.WriteLine($"OddMax={OddMaxNum:f2},");

                Console.WriteLine($"EvenSum={EvenSum:f2},");
            if (EvenMinNum == double.MaxValue)
                Console.WriteLine($"EvenMin=No,");
            else
            Console.WriteLine($"EvenMin={EvenMinNum:f2},");
            if (EvenMaxNum == double.MinValue)
                Console.WriteLine($"EvenMax=No");
            else
                Console.WriteLine($"EvenMax={EvenMaxNum:f2}");
        }
    }
}
