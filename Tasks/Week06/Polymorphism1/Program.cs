using System;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            Yemek ym = new Yemek();
            SuluYemek sy = new SuluYemek();

            ym.Servis();
            sy.Servis();
        }
    }
}
