using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    place = "Camp";
                    budget *= 0.3;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    budget *= 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    place = "Camp";
                    budget *= 0.4;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    budget *= 0.8;
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                place = "Hotel";
                budget *= 0.9;
            }
            Console.WriteLine($"{place} - {budget:f2}");
        }
    }
}
