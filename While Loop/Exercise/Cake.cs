using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalPieces = width * length;

            while (command != "STOP")
            {
                int pieces = int.Parse(command);
                totalPieces -= pieces;
                if (totalPieces <= 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (totalPieces > 0)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
        }
    }
}
