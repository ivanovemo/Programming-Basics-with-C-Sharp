using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (ticketType == "Premiere")
            {
                income = rows * columns * 12;
            }
            else if (ticketType == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (ticketType == "Discount")
            {
                income = rows * columns * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
