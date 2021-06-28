using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            for (int num = firstNum; num <= secondNum; num++)
            {
                int divider = 0;
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        divider++;
                    }
                }


                if (divider == 2)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
