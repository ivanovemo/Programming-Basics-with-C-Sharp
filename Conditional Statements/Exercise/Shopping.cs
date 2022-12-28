using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int motherboards = int.Parse(Console.ReadLine());
            int proccessors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double motherboardsPrice = motherboards * 250;
            double proccessorsPrice = proccessors * (motherboardsPrice * 0.35);
            double ramPrice = ram * (motherboardsPrice * 0.1);

            double sum = motherboardsPrice + proccessorsPrice + ramPrice;

            if (motherboards > proccessors)
            {
                sum -= sum * 0.15;
            }

            if (sum <= budget)
            {
                Console.WriteLine($"You have {budget - sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
            }
        }
    }
}
