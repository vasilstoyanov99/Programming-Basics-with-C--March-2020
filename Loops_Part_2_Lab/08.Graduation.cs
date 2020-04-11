using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double totalMarks = 0.00;

            for (int currentGrade = 0; currentGrade < 12; currentGrade++)
            {
                double currentMark = double.Parse(Console.ReadLine());

                if (currentMark >= 4.00)
                {
                    totalMarks += currentMark;
                }

                else
                {
                    currentGrade--;
                }
            }

            Console.WriteLine($"{studentName} graduated. Average grade: {totalMarks / 12.00:f2}");
        }
    }
}
