using System;

namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackage = int.Parse(Console.ReadLine());
            int markerPackage = int.Parse(Console.ReadLine());
            int litersCleaningDetergent = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double pensPrice = 5.80 * penPackage;
            double markerPrice = 7.20 * markerPackage;
            double detergentPrice = 1.20 * litersCleaningDetergent;

            double sumPrice = pensPrice + markerPrice + detergentPrice;
            double totalPrice = sumPrice - sumPrice * discountPercentage / 100;
            Console.WriteLine(totalPrice);
        }
    }
}
