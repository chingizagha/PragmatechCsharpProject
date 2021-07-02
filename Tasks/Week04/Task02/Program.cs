using System;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] randomArr = new int[5];
            
            for (int i=0; i < randomArr.Length; i++)
            {
                int randomNum = random.Next(10);
                randomArr[i] = randomNum;
            }
            
            foreach(var item in randomArr)
            {
                Console.WriteLine(item);
            }
            // First Method
            int sum = randomArr.Sum();
            Console.WriteLine(sum);


            //Second Method

            int sumSec = 0;

            for (int j = 0; j < randomArr.Length; j++)
            {
                sumSec += randomArr[j];
            }

            Console.WriteLine(sumSec);

        }   
            
            
    }
}
