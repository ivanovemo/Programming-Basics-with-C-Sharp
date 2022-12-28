using System;

namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsNum = int.Parse(Console.ReadLine());

            int neededTime = projectsNum * 3;
            Console.WriteLine($"The architect {architectName} will need {neededTime} hours to complete {projectsNum} project/s.");
        }
    }
}
