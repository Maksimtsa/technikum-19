using System;
class Osoba
{
    public void Przedstawienie()
    {
        Console.WriteLine("szymon dudzik");
    }
}
class Pracownik : Osoba
{
    public void Pracuj()
    {
        Console.WriteLine("Pracuj!!");
    }
}

class Programista : Pracownik
{
    public void Koduj() 
    {
        Console.WriteLine("koduj");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Programista prac = new Programista();
        prac.Przedstawienie();
        prac.Koduj();
        prac.Pracuj();
    }
}
