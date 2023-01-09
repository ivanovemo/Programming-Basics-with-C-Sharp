using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int boxes;
            int sumBoxes = 0;
            int freeSpace = width * length * height;

            while (command != "Done")
            {
                boxes = int.Parse(command);
                sumBoxes += boxes;
                if (freeSpace < sumBoxes)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (freeSpace > sumBoxes)
            {
                Console.WriteLine($"{freeSpace - sumBoxes} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {sumBoxes - freeSpace} Cubic meters more.");
            }
        }
    }
}
