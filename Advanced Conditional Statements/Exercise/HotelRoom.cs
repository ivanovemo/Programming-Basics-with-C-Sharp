using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = int.Parse(Console.ReadLine());

            decimal studio = 0.0m;
            decimal apartment = 0.0m;

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (nights > 7 && nights <= 14)
                {
                    studio = studio - (studio * (decimal)0.05);
                }
                else if (nights > 14)
                {
                    studio = studio - (studio * (decimal)0.3);
                    apartment = apartment - (apartment * (decimal)0.1);
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20m;
                apartment = 68.70m;
                if (nights > 14)
                {
                    studio = studio - (studio * (decimal)0.2);
                    apartment = apartment - (apartment * (decimal)0.1);
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;
                if (nights > 14)
                {
                    apartment = apartment - (apartment * (decimal)0.1);
                }
            }
            decimal studioPrice = studio * (decimal)nights;
            decimal apartmentPrice = apartment * (decimal)nights;
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
