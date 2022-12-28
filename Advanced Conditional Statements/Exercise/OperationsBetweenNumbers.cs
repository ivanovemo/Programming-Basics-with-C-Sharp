using System;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            double numTwo = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());

            double result = 0.0;
            string resultToPrint = "";

            if (action == '+' || action == '-' || action == '*')
            {
                if (action == '+')
                {
                    result = numOne + numTwo;
                }
                else if (action == '-')
                {
                    result = numOne - numTwo;
                }
                else if (action == '*')
                {
                    result = numOne * numTwo;
                }

                resultToPrint = ($"{numOne} {action} {numTwo} = {result}");

                if (result % 2 == 0)
                {
                    resultToPrint += " - even";
                }
                else
                {
                    resultToPrint += " - odd";
                }
            }


            else if (action == '/' || action == '%')
            {
                if (numTwo == 0)
                {
                    resultToPrint = ($"Cannot divide {numOne} by zero");
                }
                else
                {
                    if (action == '/')
                    {
                        result = numOne / (double)numTwo;
                        resultToPrint = ($"{numOne} {action} {numTwo} = {result:f2}");
                    }
                    else if (action == '%')
                    {
                        result = numOne % (double)numTwo;
                        resultToPrint = ($"{numOne} {action} {numTwo} = {result}");

                    }
                }
            }
            Console.WriteLine(resultToPrint);
        }
    }
}
