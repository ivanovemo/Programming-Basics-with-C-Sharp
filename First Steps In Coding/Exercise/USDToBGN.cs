using System;

namespace USDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double toBgn = usd * 1.79549;

            Console.WriteLine(toBgn);
        }
    }
}
