using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int termDeposit = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());

            double annualRatePercentage = annualRate / 100;

            double amount = deposit + termDeposit * ((deposit * annualRatePercentage) / 12);
            Console.WriteLine(amount);
        }
    }
}
