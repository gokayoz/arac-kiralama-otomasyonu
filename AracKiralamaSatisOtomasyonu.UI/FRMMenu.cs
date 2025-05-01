namespace AracKiralamaSatisOtomasyonu.UI
{
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void btnMusteriIslem_Click(object sender, EventArgs e)
        {
            FRMMusteriIslemleri fRMMusteriIslemleri = new();
            fRMMusteriIslemleri.ShowDialog();
        }

        private void btnAracIslem_Click(object sender, EventArgs e)
        {
            FRMAracIslemleri fRMAracIslemleri = new();
            fRMAracIslemleri.ShowDialog();
        }
    }
}
