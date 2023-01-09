using System;

namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;

            while ((text = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(text);
            }
        }
    }
}
