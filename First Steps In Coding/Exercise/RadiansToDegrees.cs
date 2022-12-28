using System;

namespace RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle = double.Parse(Console.ReadLine());
            double toDegrees = angle * 180 / Math.PI;

            Console.WriteLine(toDegrees);
        }
    }
}
