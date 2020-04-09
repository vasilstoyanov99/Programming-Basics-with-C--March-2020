using System;

namespace _02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountNumbers = int.Parse(Console.ReadLine());
            int MaxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < amountNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > MaxNum)
                {
                    MaxNum = currentNumber;
                }
            }
            int checker = sum - MaxNum;
            if(MaxNum == checker)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {checker}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(MaxNum - checker)}");
            }
        }
    }
}
