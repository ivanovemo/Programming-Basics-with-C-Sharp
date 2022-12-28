using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonSqm = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonSqm + 2) * 1.50;
            double paintPrice = (paintLiters + (paintLiters * 0.1)) * 14.50;
            double thinnerPrice = thinnerLiters * 5;
            double bags = 0.40;

            double sum = nylonPrice + paintPrice + thinnerPrice + bags;
            double masters = sum * 0.3 * workHours;
            double totalPrice = sum + masters;
            Console.WriteLine(totalPrice);
        }
    }
}
