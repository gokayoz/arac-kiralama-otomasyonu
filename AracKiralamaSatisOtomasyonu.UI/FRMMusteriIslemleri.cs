using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralamaSatisOtomasyonu.Core.Context;
using AracKiralamaSatisOtomasyonu.Core.Models;

namespace AracKiralamaSatisOtomasyonu.UI
{
    public partial class FRMMusteriIslemleri : Form
    {
        private readonly AracKiralamaSatisOtomasyonuDbContext _context;
        Musteri seciliMusteri;
        public FRMMusteriIslemleri()
        {
            InitializeComponent();
            _context = new AracKiralamaSatisOtomasyonuDbContext();
        }
        private void FRMMusteriIslemleri_Load(object sender, EventArgs e)
        {
            ListViewYapilandir();
            MusterileriYukle();
        }
        private void ListViewYapilandir()
        {
            lstvMusteriler.View = View.Details;
            lstvMusteriler.GridLines = true;
            lstvMusteriler.FullRowSelect = true;

            lstvMusteriler.Columns.Add("ID", 50);
            lstvMusteriler.Columns.Add("Ad Soyad", 150);
            lstvMusteriler.Columns.Add("Telefon", 120);
            lstvMusteriler.Columns.Add("Email", 150);
            lstvMusteriler.Columns.Add("Adres", 285);
        }
        private void MusterileriYukle()
        {
            lstvMusteriler.Items.Clear();

            var musteriler = _context.Musteri.ToList();

            foreach (var musteri in musteriler)
            {
                ListViewItem item = new(musteri.Id.ToString());

                item.SubItems.Add(musteri.AdSoyad);
                item.SubItems.Add(musteri.Telefon);
                item.SubItems.Add(musteri.Email);
                item.SubItems.Add(musteri.Adres);
                item.Tag = musteri;

                lstvMusteriler.Items.Add(item);
            }
        }
        private void lstvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            if (lstvMusteriler.SelectedItems.Count == 0) return;

            seciliMusteri = (Musteri)lstvMusteriler.SelectedItems[0].Tag;
            txtAdSoyad.Text = seciliMusteri.AdSoyad;
            txtTelefon.Text = seciliMusteri.Telefon;
            txtEmail.Text = seciliMusteri.Email;
            txtAdres.Text = seciliMusteri.Adres;
        }
        private bool GirdiKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Telefon alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10,11}$"))
            {
                MessageBox.Show("Telefon numarası geçerli bir format değil! Lütfen 10-11 haneli bir numara girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("E-posta adresi geçerli bir format değil!", "Veri Kontrolü", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!GirdiKontrol()) return;

            var musteri = new Musteri
            {
                AdSoyad = txtAdSoyad.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Adres = txtAdres.Text.Trim()
            };

            _context.Musteri.Add(musteri);
            _context.SaveChanges();

            MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MusterileriYukle();
            FormuTemizle();
        }
        private void FormuTemizle()
        {
            txtAdSoyad.Text = txtTelefon.Text = txtEmail.Text = txtAdres.Text = string.Empty;
            seciliMusteri = null;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sonuc = MessageBox.Show($"{seciliMusteri.AdSoyad} adlı müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                _context.Musteri.Remove(seciliMusteri);
                _context.SaveChanges();


                MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MusterileriYukle();
                FormuTemizle();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliMusteri == null)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!GirdiKontrol()) return;

            seciliMusteri.AdSoyad = txtAdSoyad.Text.Trim();
            seciliMusteri.Telefon = txtTelefon.Text.Trim();
            seciliMusteri.Email = txtEmail.Text.Trim();
            seciliMusteri.Adres = txtAdres.Text.Trim();

            _context.SaveChanges();

            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MusterileriYukle();
            FormuTemizle();
        }
    }
}