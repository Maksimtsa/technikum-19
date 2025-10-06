using System.Runtime.Intrinsics.X86;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {

            double A, B, result = 0;

            if (!double.TryParse(textBoxA.Text, out A) || !double.TryParse(textBoxB.Text, out B))
            {
                MessageBox.Show("Podaj poprawne liczby zmiennoprzecinkowe.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked)
            {
                result = A + B;
            }
            else if (radioButton2.Checked)
            {
                result = A - B;
            }
            else if (radioButton3.Checked)
            {
                result = A * B;
            }
            else if (radioButton4.Checked)
            {
                if (B == 0)
                {
                    textBoxW.Text = "Nie można dzielić przez zero";
                    return;
                }
                else
                {
                    result = A / B;
                }
            }
            else
            {
                MessageBox.Show("Wybierz działanie matematyczne.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxW.Text = result.ToString();
        }   
    }
}
