using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int TabsNum = int.Parse(Console.ReadLine());
            int Salary = int.Parse(Console.ReadLine());
            while (TabsNum > 0)
            {
                string Site = Console.ReadLine();
                if (Site == "Facebook")
                    Salary -= 150;
                else if (Site == "Instagram")
                    Salary -= 100;
                else if (Site == "Reddit")
                    Salary -= 50;
                if (Salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                --TabsNum;
            }

            if (TabsNum == 0)
            {
                Console.WriteLine($"{Salary}");
            }
        }
    }
}
