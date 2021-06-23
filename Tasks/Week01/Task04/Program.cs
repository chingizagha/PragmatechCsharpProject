using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Hi, {name} {surname}");
        }
    }
}
