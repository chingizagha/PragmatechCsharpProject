using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomArr = new int[5];
            int k = 0;
            

            for (int i=0; i<randomArr.Length; i++)
            {
                int randomNum = random.Next(10);
                randomArr[i] = randomNum;
            }
            foreach(var item in randomArr)
            {
                Console.WriteLine(item);
                Console.WriteLine("=====");
            }

            int[] reverseNum = randomArr;
            Array.Reverse(reverseNum);

            foreach(var item in reverseNum)
            {
                Console.Write(item+"=");
                
            }
            Console.WriteLine("=");

            int[] reverseNumSec = new int[5];

            for (int j= randomArr.Length-1; j >=0 ; j--)
            {
                reverseNumSec[k] = randomArr[j];
                k++;
            }

            foreach(var item in reverseNumSec)
            {
                Console.Write(item+"=");
            }






        }
    }
}
