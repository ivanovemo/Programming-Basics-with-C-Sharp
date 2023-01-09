using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int nums = int.Parse(Console.ReadLine());

                if (nums < 200)
                {
                    counter1++;
                }
                else if (nums >= 200 && nums <= 399)
                {
                    counter2++;
                }
                else if (nums >= 400 && nums <= 599)
                {
                    counter3++;
                }
                else if (nums >= 600 && nums <= 799)
                {
                    counter4++;
                }
                else
                {
                    counter5++;
                }
            }

            p1 = (counter1 / n) * 100;
            p2 = (counter2 / n) * 100;
            p3 = (counter3 / n) * 100;
            p4 = (counter4 / n) * 100;
            p5 = (counter5 / n) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
