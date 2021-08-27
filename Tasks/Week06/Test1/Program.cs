using System;

namespace Test1
{
    public  class Classe
    {
        public static int Age=17;
        public static string Name;

         static Classe()
        {
            Console.WriteLine("statik");
        }

        public Classe()
        {
            Console.WriteLine("default");
        }

        private Classe()
        {

        }
         

    }


    class Program
    {
        static void Main(string[] args)
        {

            //Classe std = new Classe();
            //int age = Classe.Age;
            //Console.WriteLine(age);
            Classe std = new Classe();//Static, Default
            Classe std1 = new Classe();//Default
            


        }
    }
}
