using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3] { { 1, 2, 3 },{ 1, 2, 3 } };
            Console.WriteLine(array.GetLowerBound()); 
        }
    }
}
