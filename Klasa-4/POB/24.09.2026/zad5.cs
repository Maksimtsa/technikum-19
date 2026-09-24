namespace zad4
{
    public class PozycjaBiblioteczna
    {
        public string Tytul { get; set; }
        public bool CzyDostepna { get; private set; }
        public PozycjaBiblioteczna(string tytul)
        {
            Tytul = tytul;
        }

        public void Wypozyc()
        {
            CzyDostepna = false;
        }
    }

    public class Ksiazka : PozycjaBiblioteczna
    {
        public string Autor { get; set; }

        public Ksiazka(string tytul, string autor) : base(tytul)
        {
            Autor = autor;
        }
    }

    public class Czasopismo : PozycjaBiblioteczna
    {
        public int Numer { get; set; }

        public Czasopismo(string tytul, int numer) : base(tytul)
        {
            Numer = numer;
        }
    }

    public class Czytelnik
    {

    }

    public class Wypozyczenie
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
