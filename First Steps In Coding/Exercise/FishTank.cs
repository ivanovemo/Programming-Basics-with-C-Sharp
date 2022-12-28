using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacity = length * width * height;
            double litersCapacity = capacity / 1000;
            double busySpace = percent / 100;
            double neededLiters = litersCapacity * (1 - busySpace);

            Console.WriteLine(neededLiters);
        }
    }
}
