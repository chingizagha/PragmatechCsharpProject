using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {

            int factorial = 1;

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num == 0)
            {
                Console.WriteLine("Enter a number greater than 0");
                num = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=1; i < num+1; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
