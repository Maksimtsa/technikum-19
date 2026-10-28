namespace ConsoleApp4
{
    public class Urzadzenie
    {
        public void Komunikat(string komunikat)
        {
            Console.WriteLine(komunikat);
        }

        public virtual string PobierzStatus()
        {
            return "Urządzenie jest w stanie nieznanym";
        }
    }

    public class Pralka : Urzadzenie
    {
        private int _numerProgramu = 0;

        public int NumerPrania(int numer)
        {
            if(numer > 0 &&  numer < 13)
            {
                _numerProgramu = numer;
            }
            else
            {
                _numerProgramu = 0;
            }
            return _numerProgramu;
        }

        public override string PobierzStatus()
        {
            return "Pralka jest gotowa do pracy";
        }
    }

    public class Odkurzac : Urzadzenie
    {
        private bool _stanOdkurzacza = false;

        public void Wlacz()
        {
            if (!_stanOdkurzacza)
            {
                _stanOdkurzacza = true;
                Komunikat("Odkurzacz włączono");
            }
        }

        public override string PobierzStatus()
        {
            if (_stanOdkurzacza)
            {
                return "Odkurzacz jest włączony";
            }
            else
            {
                return "Odkurzacz jest wyłączony";
            }
        }

    }

    public class Telewizor : Urzadzenie
    {
        private bool _statusTelewizora;
        private int[] _kanaly = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        private int _aktualnyKnal;
        private int _poziomGlosnosci = 10;

        public void WłączTelewizor()
        {
            if (_statusTelewizora)
            {
                Console.WriteLine("Telewizor był włączony");
            }
            else
            {
                _statusTelewizora = true;
                Console.WriteLine("Telewizor został włączony");
            }
        }
        public int PobierzKanal()
        {
            return _aktualnyKnal;
        }

        public int ZmienKanal(int kanal)
        {
            return _aktualnyKnal = kanal;
        }

        public int[] WszystkieKanaly()
        {
            return _kanaly;
        }

        public int ZmienGlosnosc(int poziom)
        {
            return _poziomGlosnosci = poziom;
        }

        public int GetGlosnosc()
        {
            return _poziomGlosnosci;
        }

        public override string PobierzStatus()
        {
            if (_statusTelewizora)
            {
                return $"Telewizor jest włączony na kanale {_aktualnyKnal} z głosnością {_poziomGlosnosci}";
            }
            else
            {
                return "Telewizor jest wyłączony";
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Telewizor tel = new Telewizor();
            tel.WłączTelewizor();
            tel.WszystkieKanaly();
            tel.PobierzKanal();
            tel.ZmienKanal(4);
            tel.PobierzKanal();
            tel.GetGlosnosc();
            tel.ZmienGlosnosc(12);
            tel.GetGlosnosc();

            List<Urzadzenie> list = new List<Urzadzenie>()
            {
                new Pralka(),
                new Odkurzac(),
                new Telewizor()
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.PobierzStatus());
            }
        }
    }
}
