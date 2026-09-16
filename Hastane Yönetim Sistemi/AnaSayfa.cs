namespace Hastane_Yönetim_Sistemi
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void pnlDoktor_Click(object sender, EventArgs e)
        {
            DoktorGiris doktorGiris = new DoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }

        private void pnlSekreter_Click(object sender, EventArgs e)
        {
            SekreterGiris sekreterGiris = new SekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }

        private void pnlHasta_Click(object sender, EventArgs e)
        {
            HastaGiris hastaGiris = new HastaGiris();
            hastaGiris.Show();
            this.Hide();
        }

        
    }
}
