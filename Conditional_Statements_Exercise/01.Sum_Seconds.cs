using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double Income = double.Parse(Console.ReadLine());
            double Mark = double.Parse(Console.ReadLine());
            double MinWage = double.Parse(Console.ReadLine());
            double WageScolar = 0.0;
            double MarkScholar = 0.0;
            if(Income < MinWage && Mark > 4.50)
                WageScolar += MinWage * 0.35;
            if (Mark >= 5.50 && Mark <= 6.0)
                MarkScholar += Mark * 25.0;
            if(WageScolar == 0.0 && MarkScholar == 0.0)
                Console.WriteLine("You cannot get a scholarship!");
            else if(WageScolar > 0.0 && MarkScholar == 0.0)
                Console.WriteLine($"You get a Social scholarship {Math.Floor(WageScolar)} BGN");
            else if (WageScolar == 0.0 && MarkScholar > 0.0)
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(MarkScholar)} BGN");
            else if (WageScolar > 0.0 && MarkScholar > 0.0)
            {
                if(WageScolar > MarkScholar)
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(WageScolar)} BGN");
                else if(MarkScholar > WageScolar)
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(MarkScholar)} BGN");
                else if(WageScolar == MarkScholar)
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(MarkScholar)} BGN");
            }
        }
    }
}
