using System.Net.Mime;
using System.Text.Unicode;

namespace sprawdzian
{
    internal class Program
    {
        class SprawdzaczTekstu
        {
            public string Tekst { get; set; }

            public SprawdzaczTekstu(string tekst)
            {
                Tekst = tekst;
            }

            public bool CzySameLitery(int indeks)
            {
                if (indeks >= Tekst.Length) return true;


                string n = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
                for (int i = 0; i < n.Length; i++)
                {
                    if (Tekst[indeks] == n[i])
                    {
                        return CzySameLitery(indeks + 1);
                    }
                }
                return false;

            }
        }

        public class Towar
        {
            public string Nazwa { get; set; }
            public string Kategoria { get; set; }
            public int Ilosc { get; set; }
            public Towar(string nazwa, string kategoria, int ilosc)
            {
                Nazwa = nazwa;
                Kategoria = kategoria;
                Ilosc = ilosc;
            }
        }

        class Sklep
        {
            public int SumaIlosciWKategorii(Towar[] towary, int indeks, string kategoria)
            {
                if (indeks >= towary.Length) return 0;

                if (towary[indeks].Kategoria == kategoria)
                {
                    return towary[indeks].Ilosc + SumaIlosciWKategorii(towary, indeks + 1, kategoria);
                }
                else
                {
                    return SumaIlosciWKategorii(towary, indeks + 1, kategoria);
                }
            }

            public void PosortujPoIlosci(Towar[] towary, int indeks)
            {
                if(indeks >= towary.Length) return;

                int min = indeks;
                for(int i = indeks+1; i < towary.Length; i++)
                {
                    if (towary[i].Ilosc > towary[min].Ilosc)
                    {
                        min = i;
                    }
                }
                (towary[indeks], towary[min]) = (towary[min], towary[indeks]);

                PosortujPoIlosci(towary, indeks+1);
            }
        }
        static void Main(string[] args)
        {
            //zad 1
            Console.WriteLine("zad 1");
            SprawdzaczTekstu tekst = new SprawdzaczTekstu("Programowanie");

            bool result1 = tekst.CzySameLitery(0);
            if (result1)
            {
                Console.WriteLine("zawiera tylko litery");
            }
            else
            {
                Console.WriteLine("zawiera inne znaki");
            }

            //zad 2
            Console.WriteLine("zad 2");
            Sklep sklep = new Sklep();
            Towar[] towary =
            {
                new Towar("Mysz", "elektronika", 10),
                new Towar("Klawiatura", "elektronika", 5),
                new Towar("Zeszyt", "papiernicze", 30),
                new Towar("Dlugopis", "papiernicze", 50)
            };
            Console.WriteLine("Łączna ilość towarów w kategorii elektronika: " + sklep.SumaIlosciWKategorii(towary, 0, "elektronika"));


            //zad 3
            Console.WriteLine("zad 3");
            sklep.PosortujPoIlosci(towary, 0);
            foreach(var i in towary)
            {
                Console.WriteLine(i.Nazwa + " - " + i.Ilosc);
            }
        }
    }
}
