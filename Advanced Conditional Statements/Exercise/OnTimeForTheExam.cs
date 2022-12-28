using System;

namespace OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArriving = int.Parse(Console.ReadLine());
            int minuteArriving = int.Parse(Console.ReadLine());

            int startingTimeMinutes = hourExam * 60 + minuteExam;
            int arrivalTimeMinutes = hourArriving * 60 + minuteArriving;


            int hourDifference = (startingTimeMinutes - arrivalTimeMinutes) / 60;
            int minuteDifference = (startingTimeMinutes - arrivalTimeMinutes) % 60;

            if (startingTimeMinutes - arrivalTimeMinutes == 0)
            {
                Console.WriteLine("On time");
            }
            else if (startingTimeMinutes - arrivalTimeMinutes > 0 && startingTimeMinutes - arrivalTimeMinutes <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{startingTimeMinutes - arrivalTimeMinutes} minutes before the start");
            }
            else if (startingTimeMinutes - arrivalTimeMinutes > 30 && startingTimeMinutes - arrivalTimeMinutes <= 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{startingTimeMinutes - arrivalTimeMinutes} minutes before the start");
            }
            else if (startingTimeMinutes - arrivalTimeMinutes > 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{hourDifference}:{minuteDifference:d2} hours before the start");
            }
            else if (startingTimeMinutes - arrivalTimeMinutes < 0 && startingTimeMinutes - arrivalTimeMinutes >= -59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(startingTimeMinutes - arrivalTimeMinutes)} minutes after the start");
            }
            else if (startingTimeMinutes - arrivalTimeMinutes < -59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(hourDifference)}:{Math.Abs(minuteDifference):D2} hours after the start");
            }
        }
    }
}
