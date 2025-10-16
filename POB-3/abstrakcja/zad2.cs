using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace zad2
{
    abstract class Zwierze
    {
        public string Nazwa { get; set; }

        public Zwierze(string nazwa)
        {
            Nazwa = nazwa;
        }
        public abstract void WydajDzwiek();
        public abstract void PoruszajSie();
    }

    class Pies : Zwierze
    {
        public Pies(string nazwa) : base(nazwa) { }
        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Nazwa} hau hau");
        }
        public override void PoruszajSie()
        {
            Console.WriteLine($"{Nazwa} idzie");
        }

    }
    class Kot : Zwierze
    {
        public Kot(string nazwa) : base(nazwa) { }
        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Nazwa} Miau Miau");
        }
        public override void PoruszajSie()
        {
            Console.WriteLine($"{Nazwa} idzie");
        }

    }
    class Ptak : Zwierze
    {
        public Ptak(string nazwa) : base(nazwa) { }
        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Nazwa} Ka Ka");
        }
        public override void PoruszajSie()
        {
            Console.WriteLine($"{Nazwa} leci");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zwierze> zwierze = new List<Zwierze>
            {
                new Pies("Pies"),
                new Kot("Kot"),
                new Ptak("Ptak")
            };

            for (int i = 0; i <= 2; i++)
            {
                zwierze[i].WydajDzwiek();
                zwierze[i].PoruszajSie();
            }
        }
    }
}
