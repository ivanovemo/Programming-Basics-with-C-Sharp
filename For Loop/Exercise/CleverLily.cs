using System;

namespace CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double washmachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double cashGift = 10;
            double money = 0;
            double toys = 0;

            for (int birthday = 1; birthday <= ages; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    money += cashGift;
                    money--;
                    cashGift += 10;
                }
                else
                {
                    toys++;
                }
            }

            double moneyFromSoldToys = toys * toyPrice;
            double totalMoney = moneyFromSoldToys + money;

            if (totalMoney >= washmachine)
            {
                Console.WriteLine($"Yes! {totalMoney - washmachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washmachine - totalMoney:f2}");
            }
        }
    }
}
