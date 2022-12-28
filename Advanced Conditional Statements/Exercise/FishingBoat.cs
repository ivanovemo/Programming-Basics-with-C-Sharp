using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishers = int.Parse(Console.ReadLine());

            double boatPrice = 0.0;
            if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
            }
            else if (season == "Winter")
            {
                boatPrice = 2600;
            }

            if (numFishers <= 6)
            {
                boatPrice = boatPrice - (boatPrice * 0.1);
            }
            else if (numFishers >= 7 && numFishers <= 11)
            {
                boatPrice = boatPrice - (boatPrice * 0.15);
            }
            else if (numFishers >= 12)
            {
                boatPrice = boatPrice - (boatPrice * 0.25);
            }

            bool isFishersEven = numFishers % 2 == 0;

            if (isFishersEven && season != "Autumn")
            {
                boatPrice = boatPrice - (boatPrice * 0.05);
            }

            if (budget >= boatPrice)
            {
                Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");
            }
        }
    }
}
