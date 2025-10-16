namespace zad3
{

    public abstract class Pracownik
    {
        public string Imie { get; set; }
        public string Stanowisko { get; set; }

        public abstract void ObliczPensje();

    }
    public class Programista : Pracownik
    {
        public Programista(string imie, string stanowisko)
        {
            Imie = imie;
            Stanowisko = stanowisko;
        }
        public override void ObliczPensje()
        {
            Console.WriteLine("Programista zarabia 5000zł");
        }
    }

    public class Kierownik : Pracownik
    {
        public Kierownik(string imie, string stanowisko)
        {
            Imie = imie;
            Stanowisko = stanowisko;
        }
        public override void ObliczPensje()
        {
            Console.WriteLine("kierownik zarabia 10000zł + 500zł premii");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik o1 = new Programista("Tomek", "Programista");
            Console.WriteLine($"Imię: {o1.Imie} - stanowisko: {o1.Stanowisko}");
            o1.ObliczPensje();

            Pracownik o2 = new Kierownik("Olaf", "Kierownik");
            Console.WriteLine($"Imię: {o2.Imie} - stanowisko: {o2.Stanowisko}");
            o2.ObliczPensje();
        }
    }
}
