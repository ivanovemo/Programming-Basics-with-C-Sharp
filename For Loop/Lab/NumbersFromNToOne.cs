using System;

namespace NumbersFromNToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
