namespace Polymorphism1
{
    class Yemek
    {
        public string Color;
        public string Name; 

        public virtual void Servis()
        {
            System.Console.WriteLine("Yemek");
        }
    }
}
