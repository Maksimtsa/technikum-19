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

            double number1, number2, result = 0;

            if (!double.TryParse(textBoxA.Text, out number1) || !double.TryParse(textBoxB.Text, out number2))
            {
                MessageBox.Show("Podaj poprawne liczby zmiennoprzecinkowe.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked)
            {
                result = number1 + number2;
            }
            else if (radioButton2.Checked)
            {
                result = number1 - number2;
            }
            else if (radioButton3.Checked)
            {
                result = number1 * number2;
            }
            else if (radioButton4.Checked)
            {
                if (number2 == 0)
                {
                    textBoxW.Text = "Nie można dzielić przez zero";
                    return;
                }
                else
                {
                    result = number1 / number2;
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
