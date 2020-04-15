using System;

namespace _04.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool IsFound = false;
            for (int x1 = n1; x1 <= n2; x1++)
            {
                for (int x2 = n1; x2 <= n2; x2++)
                {
                    counter++;
                    int sum = x1 + x2;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {magicNum})");
                        IsFound = true;
                        break;
                    }
                }
                if (IsFound == true)
                {
                    break;
                }
            }

            if (!IsFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
