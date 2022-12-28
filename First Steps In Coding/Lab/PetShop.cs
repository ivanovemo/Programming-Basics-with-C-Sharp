using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catsFood = int.Parse(Console.ReadLine());

            double dogsFoodPrice = 2.5 * dogsFood;
            double catsFoodPrice = 4 * catsFood;
            double totalPrice = catsFoodPrice + dogsFoodPrice;
            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
