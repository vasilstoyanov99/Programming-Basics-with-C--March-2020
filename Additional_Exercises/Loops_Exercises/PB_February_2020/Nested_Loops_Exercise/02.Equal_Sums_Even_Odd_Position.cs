using System;

namespace _02.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int currentNum = n1; currentNum <= n2; currentNum++)
            {
                string numberStr = currentNum.ToString();
                int evenSum = 0;
                int oddSum = 0;

                for (int charPlace = 0; charPlace < numberStr.Length; charPlace++)
                {
                    if (charPlace % 2 == 0)
                    {
                        oddSum += int.Parse(numberStr[charPlace].ToString());
                    }

                    else
                    {
                        evenSum += int.Parse(numberStr[charPlace].ToString()); 
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write($"{currentNum} ");
                    continue;
                }
            }
        }
    }
}
