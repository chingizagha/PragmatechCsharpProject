using System;
using System.Linq;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 8, 2, 3, 1, 5, 6 };

            //First Method =============================

            int min = array[0];

            for(int i=0; i<array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);

            //Second Method =============================

            int min2 = array.Min();
            Console.WriteLine(min2);




        }
    }
}
