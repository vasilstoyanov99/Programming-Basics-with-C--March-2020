using System;

namespace _02.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            double radians = degrees * 180.0 / Math.PI;

            Console.WriteLine(Math.Round(radians));
        }
    }
}
