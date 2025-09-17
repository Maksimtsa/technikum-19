using System;
class Pojazd
{
    public void Jedz()
    {
        Console.WriteLine("auto jedzie");
    }
}
class Samochod : Pojazd
{
    public void Tankuj()
    {
        Console.WriteLine("tankuj");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Samochod sam = new Samochod();
        sam.Jedz();
        sam.Tankuj();
    }
}
