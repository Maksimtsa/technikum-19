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

            int A, B;

            bool sukcesA = int.TryParse(textBoxA.Text, out A);
            bool sukcesB = int.TryParse(textBoxB.Text, out B);

            if (sukcesA && sukcesB)
            {        
                
                int suma = A + B;
                int ruznica = A - B;
                int iloczyn = A * B;
                int iloraz = A / B;
                textBoxAnswrS.Text = suma.ToString();
                textBoxAnswrR.Text = ruznica.ToString();
                textBoxAnswrI.Text = iloczyn.ToString();
                textBoxAnswrIl.Text = iloraz.ToString();

            }
            else
            {
                MessageBox.Show("Proszę wpisać poprawne liczby całkowite.", "Błąd danych", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
