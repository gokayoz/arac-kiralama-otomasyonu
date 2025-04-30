namespace AracKiralamaSatisOtomasyonu.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteriIslem_Click(object sender, EventArgs e)
        {
            FRMMusteriIslemleri fRMMusteriIslemleri = new();
            fRMMusteriIslemleri.ShowDialog();
        }
    }
}
