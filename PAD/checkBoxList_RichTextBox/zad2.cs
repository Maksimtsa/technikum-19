namespace zad1
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
            string wynik = $"Bok A: {a} \nBok B: {b}\n";

            foreach(var option in checkedListBox.CheckedItems)
            {
                string c = option.ToString();
                if(c == "Pole")
                {
                    wynik += $"Pole: {a * b}\n";
                }
                else if(c == "Obwód")
                {
                    wynik += $"Obwód: {(a + b) * 2}\n";
                }
            }
            richTextBox.Text = wynik;
        }
    }
}
