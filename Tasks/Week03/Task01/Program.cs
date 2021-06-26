using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;

            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                    sum = sum + i;
                
                i++;
            }
            Console.WriteLine(sum);



        }
    }
}
