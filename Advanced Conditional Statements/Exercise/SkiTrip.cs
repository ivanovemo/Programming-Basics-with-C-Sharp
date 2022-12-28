using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double onePerson = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;


            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = days - 1;
            double roomPrice = 0;

            if (room == "room for one person")
            {
                roomPrice = nights * onePerson;
            }
            else if (room == "apartment")
            {
                roomPrice = nights * apartment;
                if (days < 10)
                {
                    roomPrice -= roomPrice * 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice -= roomPrice * 0.35;
                }
                else if (days > 15)
                {
                    roomPrice -= roomPrice * 0.5;
                }

            }
            else if (room == "president apartment")
            {
                roomPrice = nights * presidentApartment;

                if (days < 10)
                {
                    roomPrice -= roomPrice * 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice -= roomPrice * 0.15;
                }
                else if (days > 15)
                {
                    roomPrice -= roomPrice * 0.2;
                }
            }

            if (rating == "positive")
            {
                roomPrice += roomPrice * 0.25;
            }
            else if (rating == "negative")
            {
                roomPrice -= roomPrice * 0.1;

            }
            Console.WriteLine($"{roomPrice:f2}");
        }
    }
}
