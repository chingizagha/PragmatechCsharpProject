using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num =2; num<=100; num++)
            {
                int divider = 0;
                for (int divisor=1; divisor<=num; divisor++)
                {
                    if (num % divisor ==0)
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
