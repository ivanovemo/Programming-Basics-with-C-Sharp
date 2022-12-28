using System;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decoration = budget * 0.1;
            double totalClothings = statists * clothingPrice;

            if (statists > 150)
            {
                totalClothings -= totalClothings * 0.1;
            }
            double sumMoney = decoration + totalClothings;

            if (sumMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sumMoney - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sumMoney:f2} leva left.");
            }
        }
    }
}
