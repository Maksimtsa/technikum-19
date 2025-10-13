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
            int total = 0;
            bool anyChecked = false;

            if (checkBox1.Checked)
            {
                total += 300;
                anyChecked = true;
            }
            if (checkBox2.Checked)
            {
                total += 100;
                anyChecked = true;
            }
            if (checkBox3.Checked)
            {
                total += 400;
                anyChecked = true;
            }
            if (checkBox4.Checked)
            {
                total += 120;
                anyChecked = true;
            }
            if (checkBox5.Checked)
            {
                total += 90;
                anyChecked = true;
            }

            if (!anyChecked)
            {
                MessageBox.Show("Musisz wybrać co najmniej jedną usługę", "Błąd");
            }
            else
            {
                MessageBox.Show($"Łączny koszt wybranych usług: {total} zł", "Suma");
            }
        }
    }
}
