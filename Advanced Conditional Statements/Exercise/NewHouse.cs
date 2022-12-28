using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double priceFlowers = 0;

            if (flowers == "Roses")
            {
                priceFlowers = numFlowers * 5;
                if (numFlowers > 80)
                {
                    priceFlowers = priceFlowers - (priceFlowers * 0.1);
                }
            }
            else if (flowers == "Dahlias")
            {
                priceFlowers = numFlowers * 3.8;
                if (numFlowers > 90)
                {
                    priceFlowers = priceFlowers - (priceFlowers * 0.15);
                }
            }
            else if (flowers == "Tulips")
            {
                priceFlowers = numFlowers * 2.80;
                if (numFlowers > 80)
                {
                    priceFlowers = priceFlowers - (priceFlowers * 0.15);
                }
            }
            else if (flowers == "Narcissus")
            {
                priceFlowers = numFlowers * 3;
                if (numFlowers < 120)
                {
                    priceFlowers = priceFlowers + (priceFlowers * 0.15);
                }
            }
            else if (flowers == "Gladiolus")
            {
                priceFlowers = numFlowers * 2.50;
                if (numFlowers < 80)
                {
                    priceFlowers = priceFlowers + (priceFlowers * 0.2);
                }
            }
            if (budget >= priceFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {budget - priceFlowers:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {priceFlowers - budget:f2} leva more.");
            }
        }
    }
}
