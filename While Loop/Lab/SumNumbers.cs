using System;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while(sum < num)
            {
                int currentNumbers = int.Parse(Console.ReadLine());
                sum += currentNumbers;
            }
            Console.WriteLine(sum);
        }
    }
}
