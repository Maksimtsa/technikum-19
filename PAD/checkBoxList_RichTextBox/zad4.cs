namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);

            string wynik = "";

            foreach(var opcja in listBoxWybor.SelectedItems)
            {
                if ( opcja.ToString() == "dodawanie")
                {
                    wynik += $"{a} + {b} = {a + b}\n";
                }
                if (opcja.ToString() == "odejmowanie")
                {
                    wynik += $"{a} - {b} = {a - b}\n";
                }
            }

            richTextBox.Text = wynik;
        }
    }
}
