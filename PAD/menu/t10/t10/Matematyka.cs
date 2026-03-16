namespace t10
{
    public partial class Matematyka : Form
    {
        public Matematyka()
        {
            InitializeComponent();
        }

        private void poilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoleProstokata poleProstokata = new PoleProstokata(this);
            this.Hide();
            poleProstokata.Show();
        }
    }
}
