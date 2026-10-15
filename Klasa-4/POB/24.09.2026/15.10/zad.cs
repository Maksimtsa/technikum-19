namespace zad;

public class Pokoj
{
    private int numerPokoju;
    private int liczbaMiejsc;

    public Pokoj(int numerPokoju, int liczbaMiejsc)
    {
        this.numerPokoju = numerPokoju;
        this.liczbaMiejsc = liczbaMiejsc;
    }

    public int GetNumerPokoju()
    {
        return numerPokoju;
    }
    public int GetLiczbaMiejsc()
    {
        return liczbaMiejsc;
    }

    public virtual string Opis()
    {
        return "To jest ogólny opis pokoju.";
    }

    
}
class PokojStandardowy : Pokoj
{
    private bool czyZwidokiem = false;

    public PokojStandardowy(int numerPokoju, int liczbaMiejsc, bool czyZwidokiem) : base(numerPokoju, liczbaMiejsc)
    {
        this.czyZwidokiem = czyZwidokiem;
    }

    public override string Opis()
    {
        if (czyZwidokiem)
            return $"Pokój standardowy numer: {GetNumerPokoju} ma {GetLiczbaMiejsc} miejsc. Z widokiem";

        return $"Pokój standardowy numer: {GetNumerPokoju} ma {GetLiczbaMiejsc} miejsc. Bez widoku";
    }
}

class Apartament : Pokoj
{
    private int numerApartamentu;
    private int floor;

    public Apartament(int numerPokoju, int liczbaMiejsc, int numerApartamentu, int floor) : base(numerPokoju, liczbaMiejsc)
    {
        this.numerApartamentu = numerApartamentu;
        this.floor = floor;
    }

    public override string Opis()
    {
        return $"Apartament numer: {numerApartamentu} na piętrze {floor}, ma {GetLiczbaMiejsc} miejsc.";
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        List<Pokoj> lista = new List<Pokoj>()
        {
            new PokojStandardowy(3, 1, true),
            new Apartament(3, 1, 7, 3)
        };


    }
}
