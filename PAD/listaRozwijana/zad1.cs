namespace _2temat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            double liczba1, liczba2, wynik = 0;
            string dzialanie = comboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(dzialanie))
            {
                MessageBox.Show("Wybierz działanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool poprawnaLiczba1 = double.TryParse(textBoxA.Text, out liczba1);
            bool poprawnaLiczba2 = double.TryParse(textBoxB.Text, out liczba2);

            if (!poprawnaLiczba1 || !poprawnaLiczba2)
            {
                MessageBox.Show("Wprowadź poprawne liczby zmiennoprzecinkowe.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            switch (dzialanie)
            {
                case "+":
                    wynik = liczba1 + liczba2;
                    break;
                case "-":
                    wynik = liczba1 - liczba2;
                    break;
                case "*":
                    wynik = liczba1 * liczba2;
                    break;
                case "/":
                    if (liczba2 == 0)
                    {
                        textBoxW.Text = "Nie można dzielić przez zero";
                        return;
                    }
                    wynik = liczba1 / liczba2;
                    break;
                default:
                    MessageBox.Show("Nieprawidłowe działanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            textBoxW.Text = wynik.ToString();
        }

    }
}

