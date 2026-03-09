namespace _3
{
    public partial class DanePodstawowe : Form
    {
        public DaneKontaktowe daneKontaktowe;
        //public Podsumowanie podsumowanie;

        public DanePodstawowe(DaneKontaktowe daneKontaktowe)
        {
            this.daneKontaktowe = new DaneKontaktowe(this);
            //this.podsumowanie = new Podsumowanie(this);
            InitializeComponent();
            this.daneKontaktowe = daneKontaktowe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            daneKontaktowe.ShowDialog();
        }
    }
}
