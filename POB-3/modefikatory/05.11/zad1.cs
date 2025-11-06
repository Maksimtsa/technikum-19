using System.Diagnostics.CodeAnalysis;

namespace zad
{
    class Jechac
    {
        protected int Predkosc { get; set; }

        public void Jedzie()
        {
            Console.WriteLine("Prękość");
        }
    }
    class Samochod : Jechac
    {
        private string Marka { get; set; }
        private string Model { get; set; }
        public double Cena { get; set; }

        public Samochod(string marka, string model, double cena, int predkosc)
        {
            Marka = marka;
            Model = model;
            Cena = cena;
            Predkosc = predkosc;
        }

        public void NazwaSamochodu()
        {
            Console.WriteLine($"Marka: {Marka}, model: {Model}");
        }
        public void WyświetlanieCeny()
        {
            if(Cena <= 0)
            {
                Console.WriteLine("Źle podana cena");
            }
            else
            {
                Console.WriteLine($"Cena samochodu: {Cena}");
            }
        }
        public void Jedzie()
        {
            Console.WriteLine($"{Model} jedzie, prędkość: {Predkosc} km/h");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod s = new Samochod("marka", "model", 21333, 123);
            s.NazwaSamochodu();
            s.WyświetlanieCeny();
            s.Jedzie();
        }
    }
}
