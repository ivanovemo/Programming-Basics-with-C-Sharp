using System;

namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double bonus = 0;

            if (number <= 100)
            {
                bonus += 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus += number * 0.2;
            }
            else
            {
                bonus += number * 0.1;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + number);
        }
    }
}
