using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlesPrice = puzzles * 2.60;
            double talkingDollsPrice = talkingDolls * 3;
            double teddyBearsPrice = teddyBears * 4.10;
            double minionsPrice = minions * 8.20;
            double trucksPrice = trucks * 2;

            double sumPrice = puzzlesPrice + talkingDollsPrice + teddyBearsPrice + minionsPrice + trucksPrice;
            int sumToys = puzzles + talkingDolls + teddyBears + minions + trucks;

            if (sumToys >= 50)
            {
                sumPrice -= sumPrice * 0.25;
            }
            sumPrice -= sumPrice * 0.1;

            if (sumPrice >= trip)
            {
                Console.WriteLine($"Yes! {sumPrice - trip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {trip - sumPrice:f2} lv needed.");
            }
        }
    }
}
