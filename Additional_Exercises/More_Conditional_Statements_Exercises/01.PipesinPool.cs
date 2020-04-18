using System;

namespace _01.PipesinPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int PoolVolume = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double Hours = double.Parse(Console.ReadLine());

            double LitersFromP1 = Hours * P1;
            double LitersFromP2 = Hours * P2;
            double LitersInPool = LitersFromP1 + LitersFromP2;
            //

            if (LitersInPool <= PoolVolume)
            {
                double PercentFull = (LitersInPool / PoolVolume) * 100;
                double P1Percent = (LitersFromP1 / LitersInPool) * 100;
                double P2Percent = (LitersFromP2 / LitersInPool) * 100;

                Console.WriteLine($"The pool is {PercentFull:f2}% full. Pipe 1: {P1Percent:f2}%. Pipe 2: {P2Percent:f2}%.");
            }
            else if (LitersInPool > PoolVolume)
            {
                double LitersLeft = LitersInPool - PoolVolume;
                Console.WriteLine($"For {Hours} hours the pool overflows with {LitersLeft:f2} liters.");
            }
        }
    }
}
