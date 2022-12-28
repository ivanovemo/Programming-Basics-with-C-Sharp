using System;

namespace VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            double hoursPerDay = (pages / pagesPerHour) / daysForReading;

            Console.WriteLine(hoursPerDay);
        }
    }
}
