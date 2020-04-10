using System;

namespace _05.Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int firstSymbol = 1; firstSymbol <= N; firstSymbol++)
            {
                for (int secondSymbol = 1; secondSymbol <= N; secondSymbol++)
                {
                    for (char thridSymbol = 'a'; thridSymbol <= L + 96; thridSymbol++)
                    {
                        for (char fourthSymbol = 'a'; fourthSymbol <= L + 96; fourthSymbol++)
                        {
                            for (int fifthSymbol = 1; fifthSymbol <= N; fifthSymbol++)
                            {
                                if (fifthSymbol > firstSymbol && fifthSymbol > secondSymbol)
                                {
                                    Console.Write($"{firstSymbol}{secondSymbol}{thridSymbol}{fourthSymbol}{fifthSymbol} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
