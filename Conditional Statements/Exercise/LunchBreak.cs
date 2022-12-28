using System;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            double episodeDuration = double.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());

            double lunchDuration = breakDuration / 8;
            double restDuration = breakDuration / 4;

            double sumActivities = lunchDuration + restDuration;
            double timeLeft = breakDuration - sumActivities;


            if (episodeDuration <= timeLeft)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(episodeDuration - timeLeft)} more minutes.");
            }
        }
    }
}
