namespace ConsoleApp1
{
    using System;

    class Matematyka
    {
        public int NWD(int a, int b)
        {
            if (b == 0)
                return a;

            return NWD(b, a % b);
        }
    }

    class Program
    {
        static void Main()
        {
            Matematyka m = new Matematyka();

            Console.Write("Podaj liczby: ");


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("NWD: " + m.NWD(a, b));
        }
    }
}
