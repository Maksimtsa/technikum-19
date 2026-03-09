using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class DaneKontaktowe : Form
    {
        private DanePodstawowe danePodstawowe;
        public DaneKontaktowe(DanePodstawowe danePodstawowe)
        {
            this.danePodstawowe = new DanePodstawowe(this);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            danePodstawowe.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        
    }
}
