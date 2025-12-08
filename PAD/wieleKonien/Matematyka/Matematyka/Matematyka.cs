namespace Matematyka
{
    public partial class Matematyka : Form
    {
        public Matematyka()
        {
            InitializeComponent();
        }

        private void buttonKalkulator_Click(object sender, EventArgs e)
        {
            Form kalkulator = new Kalkulator();
            kalkulator.ShowDialog();
        }

        private void Geometria_Click(object sender, EventArgs e)
        {
            Form geometria = new Geometria(this);
            geometria.Show();
            this.Hide();
        }
    }
}
