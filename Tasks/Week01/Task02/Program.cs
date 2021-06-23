using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            string university;

            Console.WriteLine("Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Surname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("University: ");
            university = Console.ReadLine();

            Console.WriteLine($"Name: {firstName}, Surname: {lastName}, Age: {age}, University: {university}");
        }
    }
}
