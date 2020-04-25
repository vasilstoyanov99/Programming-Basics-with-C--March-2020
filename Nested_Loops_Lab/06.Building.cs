using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());
            string type = "";

            for (int currentFloor = floors; currentFloor >= 1; currentFloor--)
            {
                for (int currentRoom = 0; currentRoom < roomsPerFloor; currentRoom++)
                {
                    if (currentFloor == floors)
                    {
                        type = "L";
                    }
                    else
                    {
                        if (currentFloor % 2 == 0)
                        {
                            type = "O";
                        }
                        else
                        {
                            type = "A";
                        }
                    }

                    Console.Write($"{type}{currentFloor}{currentRoom} ");
                }

                Console.WriteLine();
            }
        }
    }
}
