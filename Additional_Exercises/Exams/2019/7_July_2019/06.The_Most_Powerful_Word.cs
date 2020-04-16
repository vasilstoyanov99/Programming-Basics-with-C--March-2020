using System;

namespace _06.The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string theMostPowerfulWord = "";
            string currentWord = Console.ReadLine();
            double wordMaxStrength = double.MinValue;

            while (currentWord != "End of words")
            {
                double currentWordStrength = 0.00;

                for (int currentChar = 0; currentChar < currentWord.Length ; currentChar++)
                {
                    int charStrength = currentWord[currentChar];
                    currentWordStrength += charStrength;
                }

                switch (currentWord[0])
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                    case 'y':
                    case 'Y':
                        currentWordStrength *= currentWord.Length;
                        break;
                    default:
                        currentWordStrength /= currentWord.Length;
                        currentWordStrength = Math.Round(currentWordStrength);
                        break;
                }

                if (currentWordStrength > wordMaxStrength)
                {
                    wordMaxStrength = currentWordStrength;
                    theMostPowerfulWord = currentWord;
                }

                currentWord = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {theMostPowerfulWord} - {wordMaxStrength}");
        }
    }
}
