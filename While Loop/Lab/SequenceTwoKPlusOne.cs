using System;

namespace SequenceTwoKPlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 1;
            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter = 2 * counter + 1;
            }
        }
    }
}
