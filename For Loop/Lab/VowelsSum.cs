using System;

namespace VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'A')
                {
                    sum += 1;
                }
                if (text[i] == 'e' || text[i] == 'E')
                {
                    sum += 2;
                }
                if (text[i] == 'i' || text[i] == 'I')
                {
                    sum += 3;
                }
                if (text[i] == 'o' || text[i] == 'O')
                {
                    sum += 4;
                }
                if (text[i] == 'u' || text[i] == 'U')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
