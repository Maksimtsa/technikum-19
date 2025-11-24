using System.Windows.Forms;

namespace powt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            string choose = "";

            foreach (var option in listBox1.SelectedItems)
            {
                string opt = option.ToString();

                if (opt == "Wymiana oleju 300 zł")
                {
                    choose += "Wymiana oleju\n";
                    result += 300;
                }
                else if (opt == "Zmiana opon 100 zł")
                {
                    choose += "Zmiana opon\n";
                    result += 100;
                }
                else if (opt == "Wymiana klocków hamulcowych 400 zł")
                {
                    choose += "Wymiana klocków hamulcowych\n";
                    result += 400;
                }
                else if (opt == "Sprawdzenie klimatyzacji 120 zł")
                {
                    choose += "Sprawdzenie klimatyzacji\n";
                    result += 120;
                }
                else if (opt == "Diagnostyka komputerowa 90 zł")
                {
                    choose += "Diagnostyka komputerowa\n";
                    result += 90;
                }
            }

            if (result == 0)
            {
                MessageBox.Show("Nic nie wybrano");
            }
            else
            {
                string wynik = $"Łączna cena: {result} zł\n\nWybrane usługi:\n{choose}";
                richTextBox.Text = wynik;
            }
        }

    }
}
