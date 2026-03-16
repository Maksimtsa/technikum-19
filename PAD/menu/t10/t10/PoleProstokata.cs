using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t10
{
    public partial class PoleProstokata : Form
    {
        private Matematyka matematyka;
        public PoleProstokata(Matematyka m)
        {
            InitializeComponent();
            this.matematyka = m;
        }

        private void PoleProstokata_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.matematyka.Close();
        }  
    }
}
