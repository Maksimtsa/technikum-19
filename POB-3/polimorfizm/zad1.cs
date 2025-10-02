namespace zad2
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a, double b, int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cl = new Calculator();
            Console.WriteLine(cl.Add(2, 3));
            Console.WriteLine(cl.Add(2.5, 1.5));
            Console.WriteLine(cl.Add(1.5, 2.5, 3));
        }
    }
}
