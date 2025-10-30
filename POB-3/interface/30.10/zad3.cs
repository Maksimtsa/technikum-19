namespace zad3
{

    internal class Program
    {
        interface IPlatnosc
        {
            void Zaplac();
        }
        class PlatnoscKarta : IPlatnosc
        {
            public double Kwota { get; set; }
            public PlatnoscKarta(double kwota)
            {
                Kwota = kwota;
            }

            public void Zaplac()
            {
                Console.WriteLine($"Kartą: {Kwota}");
            }
        }

        class PlatnoscGotowka : IPlatnosc
        {
            public double Kwota { get; set; }
            public PlatnoscGotowka(double kwota)
            {
                Kwota = kwota;
            }

            public void Zaplac()
            {
                Console.WriteLine($"Gotówką: {Kwota}");
            }
        }
        static void Main(string[] args)
        {
            List<IPlatnosc> lista = new List<IPlatnosc>
            {
                new PlatnoscKarta(34.12),
                new PlatnoscGotowka(12.4)
            };

            foreach(var item in lista)
            {
                item.Zaplac();
            }
        }
    }
}
