namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            double A;
            double result = 0;

            bool temp = double.TryParse(textBox.Text, out A);

            if (radioButton1.Checked)
            {
                result = A * 9 / 5 + 32;
            }
            else if(radioButton2.Checked){
                result = A + 273.15;
            }
            else
            {
                MessageBox.Show("Podaj poprawn¹ wartoœæ");
                return;
            }

            textBoxResult.Text = result.ToString();
        }
    }
}
