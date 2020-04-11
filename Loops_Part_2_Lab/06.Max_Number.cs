using System;

namespace _06.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            for (int currentInput = 0; currentInput < numInputs; currentInput++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
