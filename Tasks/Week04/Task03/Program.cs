using System;
using System.Collections;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,2,3,4,5};
            int[] arr2 = {2,4,6,7,8};

            int count = 0;

            ArrayList arrayList = new ArrayList();

            for (int i=0; i< arr1.Length; i++)
            {
                for (int j=0; j< arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        count++;
                        arrayList.Add(arr1[i]);



                    }
                }
            }




            foreach (var item in arrayList)
            {
                Console.WriteLine("Duplicate items:"+ item);
            }
            Console.WriteLine("Number"+count);
        }
    }
}
