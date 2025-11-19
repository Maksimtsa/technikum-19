using System;
using System.Collections.Generic;
using System.Linq;
public class Uczen
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public List<int> Oceny { get; private set; }

        public Uczen(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Oceny = new List<int>();
        }

        public void DodajOcene(int ocena)
        {
            if (ocena >= 1 && ocena <= 6)
                Oceny.Add(ocena);
            else
                Console.WriteLine($"Nieprawidłowa ocena: {ocena} (dozwolone 1–6).");
        }

        public double Srednia()
        {
            if (Oceny.Count == 0)
                return 0;
            return Oceny.Average();
        }

        public string Info()
        {
            return $"{Imie} {Nazwisko}:  Srednia: {Srednia()}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Uczen> uczniowie = new List<Uczen>
            {
                new Uczen("Jan", "Kowalski"),
                new Uczen("Anna", "Dudzik"),
                new Uczen("Olaf", "Grygiel")
            };

            uczniowie[0].DodajOcene(5);
            uczniowie[0].DodajOcene(4);
            uczniowie[0].DodajOcene(6);
            uczniowie[1].DodajOcene(6);
            uczniowie[1].DodajOcene(5);
            uczniowie[2].DodajOcene(3);
            uczniowie[2].DodajOcene(4);

            foreach (var u in uczniowie)
            {
                Console.WriteLine(u.Info());
            }

        }
    }
