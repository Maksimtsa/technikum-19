namespace zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Euklides(12, 16));
        }

        public static int Euklides(int a, int b)
        {
            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }


            return a;
        }
    }
}
