using System;

namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }
                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }
            }
            Console.WriteLine("Max number: " + maxNum);
            Console.WriteLine("Min number: " + minNum);
        }
    }
}
