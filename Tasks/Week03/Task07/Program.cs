using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] character = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
            int count = 0;

            Console.WriteLine("Type a word");
            string word = Console.ReadLine().ToLower();
            

            for (int i=0;i<word.Length; i++)
            {
                for (int j=0; j<character.Length;j++)
                {
                    if (word[i] == character[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
