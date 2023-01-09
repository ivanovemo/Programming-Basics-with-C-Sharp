using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currClass = 1;
            double sumGrades = 0;
            int repeatClass = 0;

            while (currClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    repeatClass++;
                    if (repeatClass > 1)
                    {
                        break;
                    }
                    continue;
                }
                currClass++;
                sumGrades += grade;
            }
            if (repeatClass > 1)
            {
                Console.WriteLine($"{name} has been excluded at {currClass} grade");
            }
            else
            {
                double averageGrade = sumGrades / (currClass - 1 + repeatClass);
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
