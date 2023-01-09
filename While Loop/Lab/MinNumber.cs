using System;

namespace MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(command);
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
