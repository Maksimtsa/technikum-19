namespace przyklad
{
    public partial class Matematyka : Form
    {
        public Matematyka()
        {
            InitializeComponent();
        }

        private void kontrolka(UserControl kontrolka)
        {
            panel.Controls.Clear();
            kontrolka.Dock = DockStyle.Fill;
            panel.Controls.Add(kontrolka);
        }

        private void poleKwadratuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrolka(new PoleKwadratu());
        }

        private void poleProstokataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrolka(new PoleProstokata());
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
