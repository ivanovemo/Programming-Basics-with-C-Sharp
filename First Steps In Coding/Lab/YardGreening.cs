using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sqreMeters = double.Parse(Console.ReadLine());
            double priceForAll = sqreMeters * 7.61;
            double discount = priceForAll * 0.18;
            double totalPrice = priceForAll - discount;

            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
