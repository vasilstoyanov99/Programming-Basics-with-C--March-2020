using System;

namespace _01.ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double Mark = double.Parse(Console.ReadLine());
            if(Mark >= 5.50)
                Console.WriteLine("Excellent!");
        }
    }
}
