using System;

public class Produkt
{
    public string Nazwa;
    public int Cena;

    public Produkt(string nazwa, int cena)
    {
        Nazwa = nazwa;
        Cena = cena;
    }
}
public  class Napoj : Produkt
    {
        public double Objetosc; 

        public Napoj(string nazwa, int cena, double objetosc) : base(nazwa, cena)
        {
            Objetosc = Objetosc;
        }
    }


class Program 
{
    static void Main(string[] args)
    {
        Napoj drink = new Napoj("cola", 4, 23.5);

    }
}
