namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double A, B, result = 0;
            if (!double.TryParse(textBoxA.Text, out A) || !double.TryParse(textBoxB.Text, out B))
            {
                MessageBox.Show("Podaj poprawne liczby zmiennoprzecinkowe.", "Błąd danych");
                return;
            }
            if(checkBox1.Checked)
            {
                result = (A*2) + (B*2);
            }
            else if (checkBox2.Checked)
            {
                result = A * B;
            }
            else
            {
                MessageBox.Show("Wybierz działanie matematyczne.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxResult.Text = result.ToString();
        }
    }
}
