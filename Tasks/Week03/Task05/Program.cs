using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int total = 0;
            Console.WriteLine("Enter size for array");
            int arr = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[arr];
            while (i < arr)
            {
                Console.WriteLine($"Enter the number {i + 1}");
                string name = Console.ReadLine();
                names[i] = name;
                i++;
            }
            Console.WriteLine("Select a name:");
            string selected = Console.ReadLine();

            foreach (var item in names)
            {
                if (item == selected)
                {
                    total++;
                }
            }
            if (total == 0)
            {
                Console.WriteLine("There is no such name");
            }

            else
            {
                Console.WriteLine($"Total: {total}");
            }
        }
    }
}
