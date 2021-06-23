using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first letter:");
            string firstLetter = Console.ReadLine();

            Console.WriteLine("Enter second letter:");
            string secondLetter = Console.ReadLine();

            Console.WriteLine("Enter third letter:");
            string thirdLetter = Console.ReadLine();

            Console.WriteLine("{0}, {1}, {2}", thirdLetter, secondLetter, firstLetter);
        }

    }
}
