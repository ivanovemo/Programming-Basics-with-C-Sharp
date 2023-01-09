using System;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double onMusala = 0;
            double onMonBlanc = 0;
            double onKilimandjaro = 0;
            double onK2 = 0;
            double onEverest = 0;

            int allPeople = 0;

            for (int i = 1; i <= groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());

                allPeople += climbers;

                if (climbers <= 5)
                {
                    onMusala += climbers;
                }
                else if (climbers >= 6 && climbers <= 12)
                {
                    onMonBlanc += climbers;
                }
                else if (climbers >= 13 && climbers <= 25)
                {
                    onKilimandjaro += climbers;
                }
                else if (climbers >= 26 && climbers <= 40)
                {
                    onK2 += climbers;
                }
                else if (climbers >= 41)
                {
                    onEverest += climbers;
                }
            }
            Console.WriteLine($"{onMusala / allPeople * 100:f2}%");
            Console.WriteLine($"{onMonBlanc / allPeople * 100:f2}%");
            Console.WriteLine($"{onKilimandjaro / allPeople * 100:f2}%");
            Console.WriteLine($"{onK2 / allPeople * 100:f2}%");
            Console.WriteLine($"{onEverest / allPeople * 100:f2}%");
        }
    }
}
