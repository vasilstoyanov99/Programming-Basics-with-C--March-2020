using System;

namespace _04.Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();
            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;
            string input = Console.ReadLine();

            while (input != "End of game")
            {
                int currenFirstPlayerCard = int.Parse(input);
                int currenSecondPlayerCard = int.Parse(Console.ReadLine());

                if (currenFirstPlayerCard > currenSecondPlayerCard)
                {
                    firstPlayerPoints += currenFirstPlayerCard - currenSecondPlayerCard;
                }
                else if (currenSecondPlayerCard > currenFirstPlayerCard)
                {
                    secondPlayerPoints += currenSecondPlayerCard - currenFirstPlayerCard;
                }
                else if (currenFirstPlayerCard == currenSecondPlayerCard)
                {
                    Console.WriteLine("Number wars!");
                    currenFirstPlayerCard = int.Parse(Console.ReadLine());
                    currenSecondPlayerCard = int.Parse(Console.ReadLine());

                    if (currenFirstPlayerCard > currenSecondPlayerCard)
                    {
                        Console.WriteLine($"{firstPlayerName} is winner with {firstPlayerPoints} points");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"{secondPlayerName} is winner with {secondPlayerPoints} points");
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            if (input == "End of game")
            {
                Console.WriteLine($"{firstPlayerName} has {firstPlayerPoints} points");
                Console.WriteLine($"{secondPlayerName} has {secondPlayerPoints} points");
            }
        }
    }
}
