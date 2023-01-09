using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dailyGoal = 10000;
            int steps = 0;
            int sumSteps = 0;
            string command = Console.ReadLine();

            while (command != "Going home")
            {
                steps = int.Parse(command);
                sumSteps += steps;
                if (sumSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sumSteps - dailyGoal} steps over the goal!");
                    break;
                }
                command = Console.ReadLine();
            }
            if (sumSteps < dailyGoal)
            {
                steps = int.Parse(Console.ReadLine());
                sumSteps += steps;
                if (sumSteps >= dailyGoal)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sumSteps - dailyGoal} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{dailyGoal - sumSteps} more steps to reach goal.");
                }
            }
        }
    }
}
