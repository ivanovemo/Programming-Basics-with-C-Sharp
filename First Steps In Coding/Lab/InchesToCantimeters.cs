using System;

namespace InchesToCantimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cantimeters = inches * 2.54;
            Console.WriteLine(cantimeters);
        }
    }
}
