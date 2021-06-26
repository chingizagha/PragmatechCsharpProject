using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is greater than zero");
            }

            else if (num < 0)
            {
                Console.WriteLine($"{num} is small than zero");
            }

            else
            {
                Console.WriteLine($"{num} is equal to zero");
            }
        }
    }
}
