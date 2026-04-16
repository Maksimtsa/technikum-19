using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    class Samochod
    {
        public string Marka { get; set; }
        public int RokProdukcji { get; set; }
        public int Przebieg { get; set; }

        public Samochod(string marka, int rok, int przebieg)
        {
            Marka = marka;
            RokProdukcji = rok;
            Przebieg = przebieg;
        }
    }

    static void Main(string[] args)
    {
        Samochod[] samochody = new Samochod[]
        {
            new Samochod("BMW", 2020, 45000),
            new Samochod("Audi", 2022, 80000),
            new Samochod("Toyota", 2008, 15000)
        };

        CountCar(samochody);

        Console.WriteLine("Podaj markę do wyszukiwania: ");
        string MarkaForSearch = Console.ReadLine(); 
        MarkSearch(samochody, MarkaForSearch);
        SearchCar(samochody);
        AVGPrzebieg(samochody);
    }
    static void CountCar(Samochod[] samochody)
    {
        int aktualnyRok = DateTime.Now.Year;

        int licznik = 0;
        foreach (var s in samochody)
        {
            if (aktualnyRok - s.RokProdukcji > 10)
                licznik++;
        }
        Console.WriteLine("Starsze niż 10 lat: " + licznik);
    }

    static void MarkSearch(Samochod[] samochody, string MarkSearch)
    {
        for(int i = 0; i < samochody.Length; i++)
        {
            if (samochody[i].Marka == MarkSearch)
            {
                Console.WriteLine($"Sukcess, indeks:  {i}");
            }
        }
    }

    static void SearchCar(Samochod[] samochody)
    {
        int min = samochody[0].Przebieg;
        for(int i = 0; i < samochody.Length; i++)
        {
            if (samochody[i].Przebieg < min)
            {
                min = samochody[i].Przebieg;
            }
        }

        Console.WriteLine("Największy przebieg: " + min);
    }

    static void AVGPrzebieg(Samochod[] samochody)
    {
        int suma = 0;
        for(int i = 0; i < samochody.Length; i++)
        {
            suma += samochody[i].Przebieg;
        }
        int avg = suma / samochody.Length;
        Console.WriteLine("Średni przebieg: " + avg);
    }

    static void Reverse(Samochod[] samochod)
    {
        int left = 0; 
        int right = samochod.Length - 1;

        while(left < right)
        {
            (samochod[left], samochod[right]) = (samochod[right], samochod[left]);

            left++;
            right--;
        }
    }

}
