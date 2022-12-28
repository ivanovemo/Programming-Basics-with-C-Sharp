using System;

namespace TimePlusFifteenMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes < 45)
            {
                Console.WriteLine($"{hour}:{minutes + 15}");
            }
            else
            {
                hour++;
                if (hour > 23)
                {
                    hour = 0;
                }
                Console.WriteLine($"{hour}:{minutes - 45:D2}");
            }
        }
    }
}
