namespace _17_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "koło")
            {
                pictureBox1.Image = Image.FromFile(@"obrazy\kolo.png");
            }
            if (comboBox.SelectedItem.ToString() == "trójkąt")
            {
                pictureBox1.Image = Image.FromFile(@"obrazy\trojkat.png");
            }
            if (comboBox.SelectedItem.ToString() == "prostokąt")
            {
                pictureBox1.Image = Image.FromFile(@"obrazy\prostokat.png");
            }
        }
    }
}

