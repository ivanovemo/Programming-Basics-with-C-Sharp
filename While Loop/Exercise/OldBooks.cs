using System;

namespace OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string wantedBook = Console.ReadLine();
            int bookCounter = 0;

            while (wantedBook != "No More Books")
            {
                if (wantedBook == favoriteBook)
                {
                    break;
                }
                bookCounter++;
                wantedBook = Console.ReadLine();
            }
            if (wantedBook == favoriteBook)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
