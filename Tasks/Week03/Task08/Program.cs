using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[11];
            Random random = new Random();
            int count = 0;
            
            

            for(int i = 0; i <11; i++)
            {
                int randomNum = random.Next(10);
                numbers[i] = randomNum;
            }

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            foreach(var j in numbers)
            {
                foreach(var k in numbers)
                {
                    if (j == k)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
