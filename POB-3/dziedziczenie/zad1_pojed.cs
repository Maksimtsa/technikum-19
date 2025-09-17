using System;
class Instrument
{
    public void Graj()
    {
        Console.WriteLine("graj");
    }
}
class Gitara : Instrument
{
    public void Strojenie()
    {
        Console.WriteLine("strojenie");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gitara gitara = new Gitara();
        gitara.Strojenie();
        gitara.Graj();
    }
}
