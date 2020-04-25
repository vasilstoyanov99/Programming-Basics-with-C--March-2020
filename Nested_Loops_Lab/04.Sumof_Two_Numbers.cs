using System;

namespace _04.Sumof_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int counter = 0;
            bool isFound = false;

            for (int num1 = startNum; num1 <= endNum; num1++)
            {
                for (int num2 = startNum; num2 <= endNum; num2++)
                {
                    counter++;

                    if (num1 + num2 == magicNum)
                    {
                        x = num1;
                        y = num2;
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

        }
    }
}
