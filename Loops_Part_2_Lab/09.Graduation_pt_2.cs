using System;

namespace _09.Graduation_pt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double gradeCount = 0.00;
            double lowMarks = 0.00;
            double totalMarks = 0.00;
            while (gradeCount < 12)
            {
                double currentMark = double.Parse(Console.ReadLine());
                gradeCount++;
                if (currentMark >= 4.00)
                {
                    lowMarks = 0.00;
                    totalMarks += currentMark;
                }

                else
                {
                    lowMarks++;
                    if (lowMarks < 2)
                    {
                        gradeCount--;
                    }
                }

                if (lowMarks == 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {gradeCount} grade");
                    break;
                }
            }

            if (gradeCount == 12)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {totalMarks / gradeCount:f2}");
            }
        }
    }
}
