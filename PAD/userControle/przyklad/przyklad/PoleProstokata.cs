using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przyklad
{
    public partial class PoleProstokata : UserControl
    {
        public PoleProstokata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(textBoxA.Text, out a) || !int.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Nieprawidłowy format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = a * b;

            label5.Text = result.ToString();
        }
    }
}
