using System;

namespace _03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            
            while (input != "Stop")
            {
                int numbers = int.Parse(input);
                sum += numbers;
                input = Console.ReadLine();
            }

            if (input == "Stop")
            {
                Console.WriteLine(sum);
            }
        }
    }
}
