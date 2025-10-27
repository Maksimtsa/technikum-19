namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wynik = 0;

            foreach(var option in checkedListBox.CheckedItems)
            {
                string c = option.ToString();
                if (c == "Wymiana oleju")
                {
                    wynik += 300;
                }
                else if(c == "Zmiana opon")
                {
                    wynik += 100;
                }
                else if (c == "Wymiana klocków hamulcowych")
                {
                    wynik += 400;
                }
                else if (c == "Sprawdzenie klimatyzacji")
                {
                    wynik += 120;
                }
                else if (c == "Diagnostyka komputerowa")
                {
                    wynik += 90;
                }
            }
            richTextBox.Text = wynik.ToString();
        }
    }
}
