using System;
class Uczen
{
    public string Imie { get; set; }
    public double Srednia { get; set; }

    public Uczen(string imie, double srednia)
    {
        Imie = imie;
        Srednia = srednia;
    }
}

class Program
{
    static void Main()
    {
        Uczen[] uczniowie = new Uczen[5];

        uczniowie[0] = new Uczen("Ania", 4.5);
        uczniowie[1] = new Uczen("Bartek", 3.8);
        uczniowie[2] = new Uczen("Kasia", 5.0);
        uczniowie[3] = new Uczen("Marek", 4.2);
        uczniowie[4] = new Uczen("Ola", 4.75);


        string name = Console.ReadLine();
        for(int i = 0; i <= uczniowie.Length; i++)
        {
            if (uczniowie[i].Imie == name)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
        }
    }
}
