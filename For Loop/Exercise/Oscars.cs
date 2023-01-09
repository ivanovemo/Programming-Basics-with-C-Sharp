using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int numJudges = int.Parse(Console.ReadLine());

            double totalPoints = pointsAcademy;

            for (int i = 1; i <= numJudges; i++)
            {
                string judge = Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());

                double actorPoints = judge.Length * pointsJudge / 2;

                totalPoints += actorPoints;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
