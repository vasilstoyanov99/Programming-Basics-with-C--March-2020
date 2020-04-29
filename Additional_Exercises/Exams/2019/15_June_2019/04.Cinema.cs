using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int cinemaIncome = 0;

            while (input != "Movie time!")
            {
                int peopleToEnter = int.Parse(input);

                if (cinemaCapacity < peopleToEnter)
                {
                    Console.WriteLine("The cinema is full.");
                    break;

                }

                int totalBill = peopleToEnter * 5;
                cinemaCapacity -= peopleToEnter;

                if (peopleToEnter % 3 == 0)
                {
                    totalBill -= 5;
                }

                cinemaIncome += totalBill;
                input = Console.ReadLine();
            }

            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {cinemaCapacity} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {cinemaIncome} lv.");
        }
    }
}
