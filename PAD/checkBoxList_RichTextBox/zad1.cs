namespace zadPrzyklad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(textBoxA.Text, out a) || !int.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Nieprawidłowy format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string wynik = "";

            foreach (var opcja in checkedListBox.CheckedItems)
            {
                string operacja = opcja.ToString().ToLower();

                if (operacja == "dodawanie")
                {
                    wynik += $"{a} + {b} = {a + b}\n";
                }
                else if (operacja == "odejmowanie")
                {
                    wynik += $"{a} - {b} = {a - b}\n";
                }
                else if (operacja == "mnożenie")
                {
                    wynik += $"{a} × {b} = {a * b}\n";
                }
                else if (operacja == "dzielenie")
                {
                    if (b == 0)
                    {
                        wynik += $"{a} ÷ {b} = Nie można dzielić przez zero\n";
                    }
                    else
                    {
                        double dzielenie = (double)a / b;
                        wynik += $"{a} ÷ {b} = {dzielenie}\n";
                    }
                }
            }
            richTextBoxWynik.Text = wynik;
        }
    }
}
