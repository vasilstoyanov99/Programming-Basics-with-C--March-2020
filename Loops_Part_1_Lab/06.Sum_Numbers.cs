using System;

namespace _06.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int amaountNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < amaountNum; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }

            Console.WriteLine(sum);
        }
    }
}
