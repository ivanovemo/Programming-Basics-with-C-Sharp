using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double rangeInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForMeter = double.Parse(Console.ReadLine());

            double totalTime = rangeInMeters * timeInSecondsForMeter;
            double delayedMeters = Math.Floor(rangeInMeters / 15);
            double delayedTime = delayedMeters * 12.5;

            double hisTime = totalTime + delayedTime;
            if (hisTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {hisTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {hisTime - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}
