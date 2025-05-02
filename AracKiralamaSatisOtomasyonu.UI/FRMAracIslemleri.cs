using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralamaSatisOtomasyonu.Core.Context;
using AracKiralamaSatisOtomasyonu.Core.Models;

namespace AracKiralamaSatisOtomasyonu.UI
{
    public partial class FRMAracIslemleri : Form
    {
        private readonly AracKiralamaSatisOtomasyonuDbContext _context;
        Arac seciliArac;
        public FRMAracIslemleri()
        {
            InitializeComponent();
            _context = new AracKiralamaSatisOtomasyonuDbContext();
        }
        private void FRMAracIslemleri_Load(object sender, EventArgs e)
        {
            ListViewYapilandir();
            DummyDataEkle();
            AraclariYukle();
        }
        private void ListViewYapilandir()
        {
            lstvAracIslemler.View = View.Details;
            lstvAracIslemler.GridLines = true;
            lstvAracIslemler.FullRowSelect = true;

            lstvAracIslemler.Columns.Add("Marka Bilgisi", 120);
            lstvAracIslemler.Columns.Add("Model Bilgisi", 120);
            lstvAracIslemler.Columns.Add("Yıl Bilgisi", 120);
            lstvAracIslemler.Columns.Add("KM Bilgisi", 120);
            lstvAracIslemler.Columns.Add("Yakıt Türü", 120);
            lstvAracIslemler.Columns.Add("Şanzıman Tipi", 120);
            lstvAracIslemler.Columns.Add("Durum", 120);
            lstvAracIslemler.Columns.Add("Mevcut Durum", 120);
            lstvAracIslemler.Columns.Add("Kategori", 120);
            lstvAracIslemler.Columns.Add("Renk", 120);
        }
        private void AraclariYukle()
        {
            lstvAracIslemler.Items.Clear();

            var araclar = _context.Arac.ToList();

            foreach (var arac in araclar)
            {
                ListViewItem item = new(arac.Marka);

                item.SubItems.Add(arac.Model);
                item.SubItems.Add(arac.Yil.ToString());
                item.SubItems.Add(arac.Kilometre.ToString());
                item.SubItems.Add(arac.YakitTuru);
                item.SubItems.Add(arac.SanzimanTipi);
                item.SubItems.Add(arac.Durum);
                item.SubItems.Add(arac.MevcutDurum);
                item.SubItems.Add(arac.Kategori.KategoriAdi);
                item.SubItems.Add(arac.Renk);
                item.Tag = arac;

                lstvAracIslemler.Items.Add(item);
            }
        }
        private void lstvAracIslemler_DoubleClick(object sender, EventArgs e)
        {
            if (lstvAracIslemler.SelectedItems.Count == 0) return;

            seciliArac = (Arac)lstvAracIslemler.SelectedItems[0].Tag;
            txtMarkaBilgisi.Text = seciliArac.Marka;
            txtModelBilgisi.Text = seciliArac.Model;
            nudYilBilgisi.Value = seciliArac.Yil;
            nudKmBilgisi.Value = seciliArac.Kilometre;
            cmbYakitTurleri.Text = seciliArac.YakitTuru;
            cmbSanzimanTipleri.Text = seciliArac.SanzimanTipi;
            cmbDurumlar.Text = seciliArac.Durum;
            cmbMevcutDurumlar.Text = seciliArac.MevcutDurum;
            cmbKategoriler.Text = seciliArac.Kategori.KategoriAdi;
            cmbRenkler.Text = seciliArac.Renk;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!GirdiKontrol()) return;

            var arac = new Arac
            {
                Marka = txtMarkaBilgisi.Text.Trim(),
                Model = txtModelBilgisi.Text.Trim(),
                Yil = (int)nudYilBilgisi.Value,
                Kilometre = (int)nudKmBilgisi.Value,
                YakitTuru = cmbYakitTurleri.Text,
                SanzimanTipi = cmbSanzimanTipleri.Text,
                Durum = cmbDurumlar.Text,
                MevcutDurum = cmbMevcutDurumlar.Text,
                KategoriId = (int)cmbKategoriler.SelectedValue,
                Renk = cmbRenkler.Text
            };

            _context.Arac.Add(arac);
            _context.SaveChanges();

            MessageBox.Show("Araç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormuTemizle();
            AraclariYukle();
        }
        private void DummyDataEkle()
        {
            cmbKategoriler.DataSource = _context.Kategori.ToList();
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "Id";

            cmbYakitTurleri.Items.AddRange(new string[] { "Benzin", "Dizel", "LPG", "Elektrik", "Hibrit" });
            cmbSanzimanTipleri.Items.AddRange(new string[] { "Manuel", "Otomatik", "Yarı Otomatik" });
            cmbDurumlar.Items.AddRange(new string[] { "Kiralık", "Satılık" });
            cmbMevcutDurumlar.Items.AddRange(new string[] { "Kiralandı", "Satıldı", "Boşta" });
            cmbRenkler.Items.AddRange(new string[] { "Beyaz", "Siyah", "Mavi", "Kırmızı", "Gri", "Kiremit" });
        }
        private void FormuTemizle()
        {
            txtMarkaBilgisi.Text = txtModelBilgisi.Text = string.Empty;
            nudYilBilgisi.Value = nudYilBilgisi.Minimum;
            nudKmBilgisi.Value = nudKmBilgisi.Minimum;
            cmbYakitTurleri.SelectedIndex = -1;
            cmbSanzimanTipleri.SelectedIndex = -1;
            cmbDurumlar.SelectedIndex = -1;
            cmbMevcutDurumlar.SelectedIndex = -1;
            cmbKategoriler.SelectedIndex = -1;
            cmbRenkler.SelectedIndex = -1;
            seciliArac = null;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliArac == null)
            {
                MessageBox.Show("Lütfen silinecek aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sonuc = MessageBox.Show($"{seciliArac.Model} model aracı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                _context.Arac.Remove(seciliArac);
                _context.SaveChanges();

                MessageBox.Show("Araç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AraclariYukle();
                FormuTemizle();
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliArac == null)
            {
                MessageBox.Show("Lütfen güncellenecek aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!GirdiKontrol()) return;

            seciliArac.Marka = txtMarkaBilgisi.Text.Trim();
            seciliArac.Model = txtModelBilgisi.Text.Trim();
            seciliArac.Yil = (int)nudYilBilgisi.Value;
            seciliArac.Kilometre = (int)nudKmBilgisi.Value;
            seciliArac.YakitTuru = cmbYakitTurleri.Text;
            seciliArac.SanzimanTipi = cmbSanzimanTipleri.Text;
            seciliArac.Durum = cmbDurumlar.Text;
            seciliArac.MevcutDurum = cmbMevcutDurumlar.Text;
            seciliArac.KategoriId = (int)cmbKategoriler.SelectedValue;
            seciliArac.Renk = cmbRenkler.Text;

            _context.SaveChanges();

            MessageBox.Show("Araç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AraclariYukle();
            FormuTemizle();
        }

        private void FiltrelemeMevcutDurum()
        {
            cmbMevcutDurumlar.Items.Clear();

            if (cmbDurumlar.Text == "Kiralık")
            {
                cmbMevcutDurumlar.Items.Add("Boşta");
                cmbMevcutDurumlar.Items.Add("Kiralandı");
            }
            else if (cmbDurumlar.Text == "Satılık")
            {
                cmbMevcutDurumlar.Items.Add("Boşta");
                cmbMevcutDurumlar.Items.Add("Satıldı");
            }

            if (cmbMevcutDurumlar.Items.Count > 0)
            {
                cmbMevcutDurumlar.SelectedIndex = 0;
            }
        }

        private bool GirdiKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMarkaBilgisi.Text))
            {
                MessageBox.Show("Lütfen araç markasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarkaBilgisi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelBilgisi.Text))
            {
                MessageBox.Show("Lütfen araç modelini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelBilgisi.Focus();
                return false;
            }

            int minimumYil = 1900;
            int maximumYil = DateTime.Now.Year + 1;

            if (nudYilBilgisi.Value < minimumYil || nudYilBilgisi.Value > maximumYil)
            {
                MessageBox.Show($"Araç yılı {minimumYil} ile {maximumYil} arasında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudYilBilgisi.Focus();
                return false;
            }

            if (nudKmBilgisi.Value < 0)
            {
                MessageBox.Show("Kilometre değeri negatif olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudKmBilgisi.Focus();
                return false;
            }

            if (cmbYakitTurleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen yakıt türünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYakitTurleri.Focus();
                return false;
            }

            if (cmbSanzimanTipleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen şanzıman tipini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSanzimanTipleri.Focus();
                return false;
            }

            if (cmbDurumlar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen araç durumunu seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDurumlar.Focus();
                return false;
            }

            if (cmbMevcutDurumlar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen mevcut durumu seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMevcutDurumlar.Focus();
                return false;
            }

            if (cmbKategoriler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen araç kategorisini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbKategoriler.Focus();
                return false;
            }

            if (cmbRenkler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen araç rengini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRenkler.Focus();
                return false;
            }
            return true;
        }

        private void cmbDurumlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrelemeMevcutDurum();
        }
    }
}
