using System;

namespace _01.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());
            int booksSearchedCount = 0;

            for (int currentSearch = libraryCapacity; currentSearch > 0; currentSearch--)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == wantedBook)
                {
                    Console.WriteLine($"You checked {booksSearchedCount} books and found it.");
                    return;
                }
                else
                {
                    booksSearchedCount++;
                }
            }

           Console.WriteLine("The book you search is not here!");
           Console.WriteLine($"You checked {booksSearchedCount} books.");
        }
    }
}
