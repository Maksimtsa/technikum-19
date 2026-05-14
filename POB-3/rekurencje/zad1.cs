namespace ConsoleApp1
{
    using System;

    class Palindrom
    {
        public bool CzyPalindrom(string tekst, int lewy, int prawy)
        {
            if (lewy >= prawy)
                return true;

            if (tekst[lewy] != tekst[prawy])
                return false;

            return CzyPalindrom(tekst, lewy + 1, prawy - 1);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Podaj tekst: ");
            string tekst = Console.ReadLine();

            Palindrom p = new Palindrom();

            bool wynik = p.CzyPalindrom(tekst, 0, tekst.Length - 1);

            if (wynik)
                Console.WriteLine("Palindrom");
            else
                Console.WriteLine("To nie jest palindrom");
        }
    }
}
