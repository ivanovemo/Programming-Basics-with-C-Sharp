using System;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            double totalMoney = 0;
            while ((command = Console.ReadLine()) != "NoMoreMoney")
            {
                double moneyToIncrease = double.Parse(command);
                if (moneyToIncrease < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalMoney += moneyToIncrease;
                Console.WriteLine($"Increase: {moneyToIncrease:f2}");
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
