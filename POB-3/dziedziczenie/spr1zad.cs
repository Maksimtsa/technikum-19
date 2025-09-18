using System;

class Zwierze
{
    public string Imie;
    public int Wiek;

    public void PrzedstawSie()
    {
        Console.WriteLine("Jak zwierze ma na imie: ");
        string imie = Console.ReadLine();
        Console.WriteLine("Ile ma lat: ");
        int wiek = int.Parse(Console.ReadLine());
        Console.WriteLine($"Imie: {imie}, wiek: {wiek} lat");
    }

}

class Pies : Zwierze
{
    public string Rasa;

    public void Szczekaj()
    {
        Console.WriteLine("Pies szczeka");
    }

    public void Stan()
    {
        Console.WriteLine("Podaj ile pies ma lat");
        int wiek = int.Parse(Console.ReadLine());
        if (wiek > 5)
        {
            Console.WriteLine("Pies jest dorosły");
        }
        else
        {
            Console.WriteLine("Pies jest młody");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pies pies = new Pies();
        pies.PrzedstawSie();
        pies.Stan();
        pies.Szczekaj();
    }
}
