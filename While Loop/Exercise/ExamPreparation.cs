using System;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numBadPoints = int.Parse(Console.ReadLine());
            int counterBadPoints = 0;
            int solvedTasks = 0;
            double gradesSum = 0;
            string lastTask = "";

            while (counterBadPoints < numBadPoints)
            {
                string task = Console.ReadLine();
                if (task == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                gradesSum += grade;
                if (grade <= 4)
                {
                    counterBadPoints++;
                    if (counterBadPoints == numBadPoints)
                    {
                        break;
                    }
                }
                solvedTasks++;
                lastTask = task;
            }
            if (counterBadPoints == numBadPoints)
            {
                Console.WriteLine($"You need a break, {counterBadPoints} poor grades.");
            }
            else
            {
                double averageScore = gradesSum / solvedTasks;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {solvedTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
