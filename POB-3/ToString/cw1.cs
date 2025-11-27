using System;
using System.Collections.Generic;

namespace zad
{
    internal class Program
    {
        interface IWyszukiwalne
        {
            bool Pasuje(string fraza);
        }

        public abstract class Publikacja
        {
            public string Tytul { get; set; }
            public int RokWydania { get; set; }

            public abstract string Opis();

            public override string ToString()
            {
                return Opis();
            }
        }

        public class Ksiazka : Publikacja
        {
            public string Autor { get; set; }
            public int LiczbaStron { get; set; }

            public Ksiazka(string autor, int liczbaStron, string tytul, int rokWydania)
            {
                Autor = autor;
                LiczbaStron = liczbaStron;
                Tytul = tytul;
                RokWydania = rokWydania;
            }

            public override string Opis()
            {
                return $"Książka — Autor: {Autor}, Strony: {LiczbaStron}, Tytuł: {Tytul}, Rok: {RokWydania}";
            }
        }

        public class Czasopismo : Publikacja
        {
            public int Numer { get; set; }
            public string MiesiecznikTygodnik { get; set; }

            public Czasopismo(int numer, string rodzaj, string tytul, int rokWydania)
            {
                Numer = numer;
                MiesiecznikTygodnik = rodzaj;
                Tytul = tytul;
                RokWydania = rokWydania;
            }

            public override string Opis()
            {
                return $"Czasopismo — Nr: {Numer}, Typ: {MiesiecznikTygodnik}, Tytuł: {Tytul}, Rok: {RokWydania}";
            }
        }

        public class Komiks : Publikacja
        {
            public string AutorRysunku { get; set; }

            public Komiks(string autorRysunku, string tytul, int rokWydania)
            {
                AutorRysunku = autorRysunku;
                Tytul = tytul;
                RokWydania = rokWydania;
            }

            public override string Opis()
            {
                return $"Komiks — Rysownik: {AutorRysunku}, Tytuł: {Tytul}, Rok: {RokWydania}";
            }
        }

        static void Main(string[] args)
        {
            List<Publikacja> publikacje = new List<Publikacja>()
            {
                
            };


            
        }
    }
}
