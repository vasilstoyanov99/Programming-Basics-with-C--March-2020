using System;

namespace _09.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveH = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());
            int totalArrMin = arriveH * 60 + arriveMin;
            int totalExamMin = examH * 60 + examMin;
            if(totalArrMin == totalExamMin)
            {
                Console.WriteLine("On time");
            }
            else if(totalArrMin < totalExamMin)
            {
                int MinCheck = totalExamMin - totalArrMin;
                if (MinCheck <= 59 && MinCheck != 0)
                {
                    if(MinCheck <= 30)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{MinCheck} minutes before the start");
                    }
                    else if(MinCheck > 30 && MinCheck <= 59)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{MinCheck} minutes before the start");
                    }
                }
                else if (MinCheck >= 60)
                {
                    int earlyH = MinCheck / 60;
                    int earlyM = MinCheck % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyH}:{earlyM:d2} hours before the start");
                }
            }
            else if(totalArrMin > totalExamMin)
            {
                int MinCheck = totalArrMin - totalExamMin;
                if (MinCheck <= 59 && MinCheck != 0)
                {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{MinCheck} minutes after the start");
                }
                else if (MinCheck >= 60)
                {
                    int lateH = MinCheck / 60;
                    int lateyM = MinCheck % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateH}:{lateyM:d2} hours after the start");
                }
            }
        }
    }
}
