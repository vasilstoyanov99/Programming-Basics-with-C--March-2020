using System;

namespace _07.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTicketsCounter = 0;
            int totalStudentTickets = 0;
            int totalStandartTickets = 0;
            int totalKidsTickets = 0;
            bool isEnd = false;

            while (movie != "Finish")
            {
                int currentMovieTicketsCounter = 0;
                int seats = int.Parse(Console.ReadLine());
                
                while (true)
                {
                    string typeTicket = Console.ReadLine();

                    if (typeTicket == "End")
                    {
                        isEnd = true;
                        break;
                    }
                    else
                    {
                        totalTicketsCounter++;
                        currentMovieTicketsCounter++;

                        switch (typeTicket)
                        {
                            case "student":
                                totalStudentTickets++;
                                break;
                            case "standard":
                                totalStandartTickets++;
                                break;
                            case "kid":
                                totalKidsTickets++;
                                break;
                        }
                    }

                    if (seats == currentMovieTicketsCounter)
                    {
                        Console.WriteLine($"{movie} - {currentMovieTicketsCounter * 100.0 / seats:f2}% full.");
                        break;
                    }

                }

                if (isEnd)
                {
                    Console.WriteLine($"{movie} - {currentMovieTicketsCounter * 100.0 / seats:f2}% full.");
                    isEnd = false;
                }

                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCounter}");
            Console.WriteLine($"{totalStudentTickets * 100.0 / totalTicketsCounter:f2}% student tickets.");
            Console.WriteLine($"{totalStandartTickets * 100.0 / totalTicketsCounter:f2}% standard tickets.");
            Console.WriteLine($"{totalKidsTickets* 100.0 / totalTicketsCounter:f2}% kids tickets.");
        }
    }
}
