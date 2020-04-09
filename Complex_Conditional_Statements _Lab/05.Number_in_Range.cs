using System;

namespace _05.Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            if((Num >= - 100 && Num <= 100) && Num != 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
