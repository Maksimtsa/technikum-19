using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace przyklad
{
    public partial class PoleKwadratu : UserControl
    {
        public PoleKwadratu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;

            if (!int.TryParse(textBoxA.Text, out a))
            {
                MessageBox.Show("Nieprawidłowy format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = a * a;

            label4.Text = result.ToString();
        }
    }
}
