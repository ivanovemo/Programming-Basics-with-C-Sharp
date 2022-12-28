using System;

namespace FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;
            double price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            productPrice = 2.50;
                            break;
                        case "apple":
                            productPrice = 1.20;
                            break;
                        case "orange":
                            productPrice = 0.85;
                            break;
                        case "grapefruit":
                            productPrice = 1.45;
                            break;
                        case "kiwi":
                            productPrice = 2.70;
                            break;
                        case "pineapple":
                            productPrice = 5.50;
                            break;
                        case "grapes":
                            productPrice = 3.85;
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            productPrice = 2.70;
                            break;
                        case "apple":
                            productPrice = 1.25;
                            break;
                        case "orange":
                            productPrice = 0.90;
                            break;
                        case "grapefruit":
                            productPrice = 1.60;
                            break;
                        case "kiwi":
                            productPrice = 3;
                            break;
                        case "pineapple":
                            productPrice = 5.60;
                            break;
                        case "grapes":
                            productPrice = 4.20;
                            break;
                    }
                    break;

            }
            if (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday")
                {
                    price = productPrice * quantity;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
