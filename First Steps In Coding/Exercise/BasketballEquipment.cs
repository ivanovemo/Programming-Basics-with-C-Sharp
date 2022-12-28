using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualFee = double.Parse(Console.ReadLine());

            double shoes = annualFee - annualFee * 0.4;
            double outfit = shoes - shoes * 0.2;
            double ball = outfit * 0.25;
            double accessories = ball * 0.2;

            double sum = annualFee + shoes + outfit + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}
