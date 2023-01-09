using System;

namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(command);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber); ;
        }
    }
}
