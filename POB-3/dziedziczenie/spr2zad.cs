using System;

class Osoba
{
    public string Imie;
    public int Wiek;
}

class Uczen : Osoba
{
    int[] tabOcen = {1, 2, 3, 4, 5, };

    public void PrzedstawSie()
    {
        Console.WriteLine("Jak się nazywasz?");
        string nameSurname = Console.ReadLine();
        Console.WriteLine("Ile masz lat?");
        int wiek = int.Parse(Console.ReadLine());
        Console.WriteLine($"Nazwasz się: {nameSurname}, wiek: {wiek} lat");
    }

    public void PokazOceny(int[] tabOceny)
    {
        foreach(var oceny in tabOcen)
        {
            Console.Write($"{oceny}, ");
        }
    }

    public void Srednia(int[] tabOceny)
    {
        int sum = 0;
        foreach (var oceny in tabOcen)
        {
            sum += oceny;
        }
        Console.WriteLine($"Średnia ocen: {sum/tabOcen.Length}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Uczen uczen = new Uczen();
        int[] tabOcen = { 1, 2, 3, 4, 5, };
        uczen.PrzedstawSie();
        uczen.PokazOceny(tabOcen);
        uczen.Srednia(tabOcen);
    }
}
