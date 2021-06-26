using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            while (num != 0);
            Console.WriteLine(sum);
        }
    }
}
