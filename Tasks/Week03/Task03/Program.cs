using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int shots = 0;
            Random randomNumbers = new Random();
            int random = randomNumbers.Next(5);

            do
            {
            Console.WriteLine("Enter a number");
            int guess = Convert.ToInt32(Console.ReadLine());
            shots++;

            if (shots == 5)
            {
                    Console.WriteLine("Sizin texmin haqqiniz bitmishdir");
                    Console.WriteLine($"Duzgun Eded: {random}");
            }
            else
            {
                if (guess > random)
                {     
                    Console.WriteLine("Daxil etdiyiniz eded tutulan ededden boyukdur");
                }

                else if (guess < random)
                {
                    Console.WriteLine("Daxil etdiyiniz eded tutulan ededden kicikdir");
                }

                else
                {
                    Console.WriteLine("Tebrikler siz duz tapdiniz");
                    break;
                }

            }
            

            }
            while (shots < 5);
        }
    }
}
