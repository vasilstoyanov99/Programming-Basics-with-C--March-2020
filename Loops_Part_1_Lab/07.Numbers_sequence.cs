using System;

namespace _07.Numbers_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int AmountNumbers = int.Parse(Console.ReadLine());
            int MaxNumber = int.MinValue;
            int MinNumber = int.MaxValue;

            for (int i = 0; i < AmountNumbers; i++)
            {
                int CurrentNumber = int.Parse(Console.ReadLine());
                if(CurrentNumber > MaxNumber)
                {
                    MaxNumber = CurrentNumber;
                }
                if(CurrentNumber < MinNumber)
                {
                    MinNumber = CurrentNumber;
                }
            }
            Console.WriteLine($"Max number: {MaxNumber}");
            Console.WriteLine($"Min number: {MinNumber}");
        }
    }
}
