using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double vegetarianPrice = vegetarianMenu * 8.15;

            double sum = chickenPrice + fishPrice + vegetarianPrice;
            double dessert = sum * 0.2;
            double totalAmount = sum + dessert + 2.50;

            Console.WriteLine(totalAmount);
        }
    }
}
