using System;

public class Pojazd
{
    public string Nazwa { get; set; }
    public int Predkosc { get; set; }

    public Pojazd (string nazwa, int predkosc)
    {
        Nazwa = nazwa;
        Predkosc = predkosc;
    }

    public void WyświetlInfo()
    {
        Console.WriteLine($"Nazwa: {Nazwa}, Prędkość: {Predkosc}.");
    }
}
interface IRuchomy
{
    void PoruszajSie();
}

interface IPlywajacy
{
    void Plyn();
}


class Amfibia : Pojazd, IPlywajacy, IRuchomy
{
    public Amfibia(string nazwa, int predkosc) : base(nazwa, predkosc)
    {

    }
    public void Plyn()
    {
        Console.WriteLine("Amfibia płynie");
    }

    public void PoruszajSie()
    {
        Console.WriteLine("Amfibia jedzie");
    }

}
class Program
{
    static void Main()
    {
        Amfibia nowy = new Amfibia("pojazd", 50);
        nowy.Plyn();
        nowy.PoruszajSie();
        nowy.WyświetlInfo();
    }
}





