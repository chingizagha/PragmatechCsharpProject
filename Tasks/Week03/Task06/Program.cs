using System;
using System.Collections;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many names do you want to add:");
            int number = Convert.ToInt32(Console.ReadLine());


            while (number % 2 != 0)
            {
                Console.WriteLine("Please enter the even numbers:");
                number = Convert.ToInt32(Console.ReadLine());
            }

            string[] names = new string[number];

            for (int i =0; i<number; i++)
            {
                Console.WriteLine($"Enter the {i + 1}. name");
                string addNames = Console.ReadLine();
                names[i] = addNames;
            }

            foreach(var item in names)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
