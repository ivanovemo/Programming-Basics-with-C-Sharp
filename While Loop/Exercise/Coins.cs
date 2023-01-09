using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinsCounter = 0;

            while (change > 0)
            {
                if (change >= 2)
                {
                    change -= 2;
                    coinsCounter++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    coinsCounter++;
                }
                else if (change >= 0.50m)
                {
                    change -= 0.50m;
                    coinsCounter++;
                }
                else if (change >= 0.20m)
                {
                    change -= 0.20m;
                    coinsCounter++;
                }
                else if (change >= 0.10m)
                {
                    change -= 0.10m;
                    coinsCounter++;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                    coinsCounter++;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                    coinsCounter++;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                    coinsCounter++;
                }
            }
            Console.WriteLine(coinsCounter);
        }
    }
}
