using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[6] { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            for(int i=0; i<number.Length; i++)
            {
               if(number[i] % 2 != 0)
                {
                    count++;
                }
            }

            int[] oddNumber = new int[count];
            int k = 0;
            for(int j=0; j<number.Length; j++)
            {
                if (number[j] % 2 != 0)
                {
                    oddNumber[k] = number[j];
                    k++;
                }
            }

            foreach(var item in oddNumber)
            {
                Console.WriteLine(item);
            }


        }
    }
}
