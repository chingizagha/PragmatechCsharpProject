using System;
using System.Collections;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList user = new ArrayList();

            Start:  

            Console.WriteLine("Sport komplekse qeydiyyat sistemi");
            Console.WriteLine("Edeceyiniz emeliyyati secin");
            Console.WriteLine("=================================");
            Console.WriteLine("1-Uzv daxil edin");
            Console.WriteLine("2-Uzvu qeydiyyatdan silin");
            Console.WriteLine("3-Uzvlerin siyahisini gorun");
            Console.WriteLine("4-Uzvlerin siyahini ters cevirin");
            Console.WriteLine("5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin");
            Console.WriteLine("6-Uzvlerin siyahisini bashdan sona siralayin");
            Console.WriteLine("7-Butun uzvlerin qeydiyyatini silin");
            Console.WriteLine("8-Sport komlekse qeydiyyat sisteminden cixin");
            Console.WriteLine("=================================");

            Console.WriteLine("Choose the operation between 1-8");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Uzv daxil etme ekranina xosh geldiniz");

                    Console.WriteLine("How many user do you wanna add:");
                    int userNum = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i=0; i < userNum; i++)
                    {
                        Console.WriteLine("Add:");
                        string userAdd = Console.ReadLine();
                        user.Add(userAdd);
                    }

                    Console.WriteLine("emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;

                case 2:
                    Console.WriteLine("Uzv silme ekranina xosh geldiniz");

                    foreach(var item in user)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Enter the name of the use you want to delete");
                    string userRemove = Console.ReadLine();

                    user.Remove(userRemove);

                    Console.WriteLine("Emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;

                case 3:
                    Console.WriteLine("Uzvlerin siyahisi ekranina xosh geldiniz");

                    foreach (var item in user)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;

                case 4:
                    Console.WriteLine("Uzvlerin siyahisi ters cevirme ekranina xosh geldiniz");
                    Console.WriteLine("Uzvler normal halda");
                    foreach (var item in user)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("========================");
                    user.Reverse();
                    Console.WriteLine("Uzvler ters cevrilmis halda");
                    foreach (var item in user)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;

                case 5:
                    Console.WriteLine("Uzvlerin qeydiyyatda olub olmama yoxlamaq ekranina xosh geldiniz");

                    Console.WriteLine("Yoxlamaq istediyiviz uzvun adini daxil edin");
                    string userSearch = Console.ReadLine();

                    if (user.Contains(userSearch))
                    {
                        Console.WriteLine("Daxil edilmish uzv qeydiyyatdadir");
                    }
                    else
                    {
                        Console.WriteLine("Daxil edilmish uzv tapilmadi");
                    }

                    Console.WriteLine("Emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;

                case 6:
                    Console.WriteLine("Uzvlerin siyahisini basdan sona siralanma ekranina xosh geldiniz");

                    user.Sort();
                    foreach (var item in user)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;

                case 7:
                    Console.WriteLine("Butun uzvlerin qeydiyyatini silme ekranika xosh geldiniz");

                    user.Clear();

                    Console.WriteLine("Emeliyyat ugurla basha catdi");
                    Console.WriteLine("Enteri vurun");
                    Console.ReadKey();

                    goto Start;
                case 8:
                    break;
            }
        }
    }
}
