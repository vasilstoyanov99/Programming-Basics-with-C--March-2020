using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int leves = int.Parse(Console.ReadLine());
            int roomsPerLevel = int.Parse(Console.ReadLine());
            int levelCounter = leves;
            int lastLevelCheck = leves;
            int roomCounter = roomsPerLevel;

            for (int currentLevel = leves; currentLevel >= 1; currentLevel--)
            {
                for (int currentRoom = 0; currentRoom < roomsPerLevel; currentRoom++)
                {
                    if (currentLevel == leves)
                    {
                            Console.Write($"L{currentLevel}{currentRoom} ");

                            if (currentRoom + 1 == roomsPerLevel)
                            {
                                Console.WriteLine("");
                            }
                        continue;
                    }

                    if (currentLevel % 2 == 0)
                    {
                        Console.Write($"O{currentLevel}{currentRoom} ");
                    }

                    else
                    {
                        Console.Write($"А{currentLevel}{currentRoom} ");
                    }

                    if (currentRoom + 1 == roomsPerLevel)
                    {
                        Console.WriteLine("");
                    }
                }
            }

        }
    }

}

