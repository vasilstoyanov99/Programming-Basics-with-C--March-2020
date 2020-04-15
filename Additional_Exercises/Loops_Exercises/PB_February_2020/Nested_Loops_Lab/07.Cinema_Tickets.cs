using System;

namespace _07.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = "";
            double totalTickets = 0;
            double totalKidsTickets = 0;
            double totalStandartTickets = 0;
            double totalStudentTickets = 0;
            while ((firstInput = Console.ReadLine()) != "Finish")
            {
                double seats = int.Parse(Console.ReadLine());
                string type = "";
                double seatsChecket = seats;
                double currentKidsTickets = 0;
                double currentStandartTickets = 0;
                double currentStudentTickets = 0;
                while ((type = Console.ReadLine()) != "End")
                {
                   

                    if (type == "student")
                    {
                        currentStudentTickets++;
                        totalTickets++;
                        seatsChecket--;
                        totalStudentTickets++;
                    }

                    else if (type == "standard")
                    {
                        currentStandartTickets++;
                        totalTickets++;
                        seatsChecket--;
                        totalStandartTickets++;
                    }

                    else if (type == "kid")
                    {
                        currentKidsTickets++;
                        totalTickets++;
                        seatsChecket--;
                        totalKidsTickets++;
                    }

                    if (seatsChecket == 0)
                    {
                        double totalCurrentTickets = currentKidsTickets + currentStandartTickets + currentStudentTickets;
                        Console.WriteLine($"{firstInput} - {totalCurrentTickets / seats * 100.0:f2}% full.");
                        break;
                    }
                }

                if (type == "End")
                {
                    double totalCurrentTickets = currentKidsTickets + currentStandartTickets + currentStudentTickets;
                    Console.WriteLine($"{firstInput} - {totalCurrentTickets / seats * 100:f2}% full.");
                }

            }

            if (firstInput == "Finish")
            {
                Console.WriteLine($"Total tickets: {Math.Truncate(totalTickets)}");
                Console.WriteLine($"{totalStudentTickets / totalTickets * 100.0:f2}% student tickets.");
                Console.WriteLine($"{totalStandartTickets / totalTickets * 100.0:f2}% standard tickets.");
                Console.WriteLine($"{totalKidsTickets / totalTickets * 100.0:f2}% kids tickets.");
            }
        }
    }
}
