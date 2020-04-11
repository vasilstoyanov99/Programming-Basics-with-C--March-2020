using System;

namespace _07.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int currentInput = 0; currentInput < numInputs; currentInput++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < minNumber)
                {
                    minNumber = currentNum;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
