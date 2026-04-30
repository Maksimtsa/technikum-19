namespace sprPoprawa
{
    internal class Program
    {
        public class ArrayManeger
        {
            static int[] Tablica;

            public ArrayManeger(int[] tablica) 
            {
                tablica = Tablica;
            }

            public void FillRandom(int n)
            {
                Random rand = new Random();
                for(int i = 0; i < n; i++)
                {
                    Tablica[i] = rand.Next(0, 10);
                }
            }

            public void InsertionSort()
            {
                for(int i = 1; i < Tablica.Length; i++)
                {
                    int value = Tablica[i];
                    int j = i - 1;
                    while(j >= 0 && Tablica[j] > value)
                    {
                        Tablica[j+1] = Tablica[j];
                        j--;
                    }
                    Tablica[j+1] = value;
                }
            }

            public void Display()
            {
                foreach(int i in Tablica)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] tab = { 5, 2, 8, 0, 3, 1 };
            //zad 1
            Console.WriteLine("Zadanie 1");
            InserionSort(tab);
            foreach(int i in tab)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            //zad 2
            Console.WriteLine("Zadanie 2");
            if(IsSorted(tab) == false)
            {
                InserionSort(tab);
            }

            //zad 3
            ArrayManeger tab3 = new ArrayManeger(new int[] { });
            tab3.FillRandom(10);
            tab3.InsertionSort();
            tab3.Display();

            //zad 4
            Console.WriteLine("Zadanie 4");
            int length = 5;
            int[] tab4 = new int[length];
            bool k = true;
            int j = 0;
            while (k == true)
            {
                Console.WriteLine("Podaj 5 liczb do tablicy, jeśli koniec to napisz 0");
                int number = int.Parse(Console.ReadLine());
                if(number == 0)
                {
                    k = false;
                }
                else
                {
                    tab4[j] = number;
                    j++;
                }
            }

            InserionSort(tab4);
            foreach(int i in tab4)
            {
                Console.Write(i + ", ");
            }
        }

        static void InserionSort(int[] tab)
        {
            for(int i = 1; i < tab.Length; i++)
            {
                int value = tab[i];
                int j = i - 1;
                while(j >= 0 && tab[j] < value)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = value;
            }
        }

        static bool IsSorted(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < tab[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
