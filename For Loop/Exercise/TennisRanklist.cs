using System;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double positionPoints = 0;

            double winsCounter = 0;

            for (int i = 1; i <= tournaments; i++)
            {

                string position = Console.ReadLine();

                if (position == "W")
                {
                    positionPoints += 2000;
                    winsCounter++;
                }
                else if (position == "F")
                {
                    positionPoints += 1200;
                }
                else if (position == "SF")
                {
                    positionPoints += 720;
                }
            }
            double finalPoints = positionPoints + startingPoints;
            Console.WriteLine($"Final points: " + finalPoints);
            double averagePoints = positionPoints / tournaments;
            Console.WriteLine($"Average points: " + Math.Floor(averagePoints));
            double percentageWonTournaments = winsCounter / tournaments * 100;
            Console.WriteLine($"{percentageWonTournaments:f2}%");
        }
    }
}
