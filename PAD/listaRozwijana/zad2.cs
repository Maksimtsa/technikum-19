namespace lista2zad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxW.Text = "";
                return;
            }

            if (!double.TryParse(textBoxA.Text, out double a) || a <= 0)
            {
                textBoxW.Text = "Podaj poprawną wartość > 0 dla a";
                return;
            }

            if (!double.TryParse(textBoxB.Text, out double b) || b <= 0)
            {
                textBoxW.Text = "Podaj poprawną wartość > 0 dla b";
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "pole")
            {
                double pole = a * b;
                textBoxW.Text = $"Pole prostokąta: {pole:F2}";
            }
            else if (comboBox1.SelectedItem.ToString() == "obwod")
            {
                double obwod = 2 * (a + b);
                textBoxW.Text = $"Obwód prostokąta: {obwod:F2}";
            }
        }
    }
}
