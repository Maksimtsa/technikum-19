using System;
class Figura
{
    public void ObliczPole()
    {
        Console.WriteLine("pole");
    }
}
class Kwadrat : Figura
{
    public void PoleKwadratu()
    {
        Console.WriteLine("pole kwadratu");
    }
}

class Kolo : Figura
{
    public void PoleKola()
    {
        Console.WriteLine("pole kola");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kwadrat kw = new Kwadrat();
        kw.ObliczPole();
        kw.PoleKwadratu();

        Kolo kolo = new Kolo();
        kolo.ObliczPole();
        kolo.PoleKola();
    }
}
