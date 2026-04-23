namespace sprawdzian
{
    internal class Program
    {
        public class Rower
        {
            public string Model { get; set; }
            public int RokProdukcji { get; set; }
            public decimal CenaZaGodzine { get; set; }

            public Rower(string model, int rokProdukcji, decimal cenaZaGodzine)
            {
                Model = model;
                RokProdukcji = rokProdukcji;
                CenaZaGodzine = cenaZaGodzine;
            }
        }
        static void Main(string[] args)
        {
            Rower[] rowery =
            {
                new Rower("Model1", 2017, 6000m),
                new Rower("Model2", 2024, 8000m),
                new Rower("Model3", 2016, 5000m),
                new Rower("Model4", 2015, 4000m),
                new Rower("Model5", 2025, 9000m)
            };

            oldestRower(rowery);
            avgCost(rowery);
            LinearSearch(rowery, "Model3");
            BubbleSort(rowery);
            newTable(rowery);
        }

        static void oldestRower(Rower[] rowery)
        {
            int old = rowery[0].RokProdukcji;

            for(int i = 1; i <  rowery.Length; i++)
            {
                if (rowery[i].RokProdukcji < old)
                {
                    old = rowery[i].RokProdukcji;
                }
            }

            Console.WriteLine($"Najstarszy rower: {old}");
        }

        static void avgCost(Rower[] rowery)
        {
            decimal sum = 0;
            for(int i = 0; i < rowery.Length; i++)
            {
                sum += rowery[i].CenaZaGodzine;
            }

            decimal avg = sum / rowery.Length;
            Console.WriteLine("Średnia cena: " + avg);
        }

        static void LinearSearch(Rower[] rowery, string model)
        {
            for(int i = 0; i < rowery.Length; i++)
            {
                if (rowery[i].Model == model)
                {
                    Console.WriteLine("Sukces, rower znaleziony indeks: " + i);
                }
            }
        }

        static void BubbleSort(Rower[] rowery)
        {
            for(int i = 0; i < rowery.Length - 1; i++)
            {
                for(int j = 0; j < rowery.Length - 1; j++)
                {
                    if (rowery[j].CenaZaGodzine < rowery[j + 1].CenaZaGodzine)
                    {
                        (rowery[j], rowery[j + 1]) = (rowery[j + 1], rowery[j]);
                    }
                }
            }
            Console.WriteLine("Posortowana tablica według ceny:");
            foreach(var rower in rowery)
            {
                Console.WriteLine(rower.Model + " " + rower.RokProdukcji + " " + rower.CenaZaGodzine);
            }
        }

        static void newTable(Rower[] rowery)
        {
            int count = 0;
            for(int i = 0; i < rowery.Length; i++)
            {
                int rok = 2026 - rowery[i].RokProdukcji;
                if(rok < 5)
                {
                    count++; 
                }
            }

            Rower[] newRowery = new Rower[count];
            int j = 0;
            for(int i = 0; i < rowery.Length; i++)
            {
                int rok = 2026 - rowery[i].RokProdukcji;
                if (rok < 5)
                {
                    newRowery[j] = rowery[i];
                    j++;
                }
            }
            Console.WriteLine("Nowa tablica z rowerami młodszymi niż 5 lat: ");
            foreach (var rower in newRowery)
            {
                Console.WriteLine(rower.Model + " " + rower.RokProdukcji + " " + rower.CenaZaGodzine);
            }
        }
    }
}
