using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} greater than {num2}");
            }

            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} greater than {num1}");
            }

            else
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }

        }
    }
}
