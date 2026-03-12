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


        //zad 1
        string name = "Ania";
        for (int i = 0; i < uczniowie.Length; i++)
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

        //zad 2
        double maxAvg = uczniowie[0].Srednia;
        for(int i = 0; i < uczniowie.Length; i++)
        {
            if (uczniowie[i].Srednia > maxAvg)
            {
                maxAvg = uczniowie[i].Srednia;
            }
        }
        Console.WriteLine($"Najwiękasz średnia: {maxAvg}");

        //zad 3
        double minAvg = uczniowie[0].Srednia;
        for (int i = 0; i < uczniowie.Length; i++)
        {
            if (uczniowie[i].Srednia < minAvg)
            {
                minAvg = uczniowie[i].Srednia;
            }
        }
        Console.WriteLine($"Najmniejsza średnia: {minAvg}");

        //zad 4
        int count = 0;
        double sum = 0;
        for (int i = 0; i < uczniowie.Length; i++)
        {
            sum += uczniowie[i].Srednia;
            count++;
        }
        Console.WriteLine($"Średnia klasy: {sum / count}");

        //zad 5
        for (int i = 0; i < uczniowie.Length; i++)
        {
            for (int j = 0; j < uczniowie.Length - 1; j++)
            {
                if (uczniowie[j].Srednia > uczniowie[j + 1].Srednia)
                {
                    Uczen temp = uczniowie[j];
                    uczniowie[j] = uczniowie[j + 1];
                    uczniowie[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < uczniowie.Length; i++)
        {
            Console.WriteLine($"{uczniowie[i].Imie} - {uczniowie[i].Srednia}");
        }
    }
}
