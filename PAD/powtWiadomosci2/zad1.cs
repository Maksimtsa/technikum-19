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
            foreach (var option in checkedListBox.CheckedItems)
            {
                string opt = option.ToString();
                if (opt == "Wymiana oleju 300 zł")
                {
                    result += 300;
                }
                else if (opt == "Zmiana opon 100 zł")
                {
                    result += 100;
                }
                else if(opt == "Wymiana klocków hamulcowych 400 zł")
                {
                    result += 400;
                }
                else if(opt == "Sprawdzenie klimatyzacji 120 zł")
                {
                    result += 120;
                }
                else if(opt == "Diagnostyka komputerowa 90 zł")
                {
                    result += 90;
                }

                if(result == 0)
                {
                    MessageBox.Show("Nic nie wybrano");
                }
                else
                {
                    textBox.Text = result.ToString();
                }

            }
        }
    }
}
