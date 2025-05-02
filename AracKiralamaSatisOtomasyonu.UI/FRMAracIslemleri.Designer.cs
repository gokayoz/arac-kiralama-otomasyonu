namespace AracKiralamaSatisOtomasyonu.UI
{
    partial class FRMAracIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMarkaBilgisi = new TextBox();
            cmbKategoriler = new ComboBox();
            nudYilBilgisi = new NumericUpDown();
            btnKiraRaporu = new Button();
            lstvAracIslemler = new ListView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtModelBilgisi = new TextBox();
            nudKmBilgisi = new NumericUpDown();
            cmbYakitTurleri = new ComboBox();
            cmbSanzimanTipleri = new ComboBox();
            cmbDurumlar = new ComboBox();
            cmbMevcutDurumlar = new ComboBox();
            cmbRenkler = new ComboBox();
            btnSatisRaporu = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYilBilgisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKmBilgisi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 33);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka Bilgisi:";
            // 
            // txtMarkaBilgisi
            // 
            txtMarkaBilgisi.Location = new Point(408, 30);
            txtMarkaBilgisi.Name = "txtMarkaBilgisi";
            txtMarkaBilgisi.Size = new Size(459, 27);
            txtMarkaBilgisi.TabIndex = 1;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(407, 338);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(459, 28);
            cmbKategoriler.TabIndex = 2;
            // 
            // nudYilBilgisi
            // 
            nudYilBilgisi.Location = new Point(409, 103);
            nudYilBilgisi.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudYilBilgisi.Name = "nudYilBilgisi";
            nudYilBilgisi.Size = new Size(458, 27);
            nudYilBilgisi.TabIndex = 3;
            // 
            // btnKiraRaporu
            // 
            btnKiraRaporu.Location = new Point(231, 461);
            btnKiraRaporu.Name = "btnKiraRaporu";
            btnKiraRaporu.Size = new Size(136, 29);
            btnKiraRaporu.TabIndex = 4;
            btnKiraRaporu.Text = "Kira Raporu";
            btnKiraRaporu.UseVisualStyleBackColor = true;
            // 
            // lstvAracIslemler
            // 
            lstvAracIslemler.Location = new Point(12, 512);
            lstvAracIslemler.Name = "lstvAracIslemler";
            lstvAracIslemler.Size = new Size(1158, 429);
            lstvAracIslemler.TabIndex = 5;
            lstvAracIslemler.UseCompatibleStateImageBehavior = false;
            lstvAracIslemler.DoubleClick += lstvAracIslemler_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 68);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Model Bilgisi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 105);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "Yıl Bilgisi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 143);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "KM Bilgisi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 181);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 0;
            label5.Text = "Yakıt Türü:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 220);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 0;
            label6.Text = "Şanzıman Tipi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 259);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Durum:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 299);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 0;
            label8.Text = "Mevcut Durum:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 341);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 0;
            label9.Text = "Kategori:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 385);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 0;
            label10.Text = "Renk:";
            // 
            // txtModelBilgisi
            // 
            txtModelBilgisi.Location = new Point(408, 65);
            txtModelBilgisi.Name = "txtModelBilgisi";
            txtModelBilgisi.Size = new Size(459, 27);
            txtModelBilgisi.TabIndex = 1;
            // 
            // nudKmBilgisi
            // 
            nudKmBilgisi.Location = new Point(408, 141);
            nudKmBilgisi.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudKmBilgisi.Name = "nudKmBilgisi";
            nudKmBilgisi.Size = new Size(458, 27);
            nudKmBilgisi.TabIndex = 3;
            // 
            // cmbYakitTurleri
            // 
            cmbYakitTurleri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYakitTurleri.FormattingEnabled = true;
            cmbYakitTurleri.Location = new Point(407, 178);
            cmbYakitTurleri.Name = "cmbYakitTurleri";
            cmbYakitTurleri.Size = new Size(459, 28);
            cmbYakitTurleri.TabIndex = 2;
            // 
            // cmbSanzimanTipleri
            // 
            cmbSanzimanTipleri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSanzimanTipleri.FormattingEnabled = true;
            cmbSanzimanTipleri.Location = new Point(408, 217);
            cmbSanzimanTipleri.Name = "cmbSanzimanTipleri";
            cmbSanzimanTipleri.Size = new Size(459, 28);
            cmbSanzimanTipleri.TabIndex = 2;
            // 
            // cmbDurumlar
            // 
            cmbDurumlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurumlar.FormattingEnabled = true;
            cmbDurumlar.Location = new Point(407, 256);
            cmbDurumlar.Name = "cmbDurumlar";
            cmbDurumlar.Size = new Size(459, 28);
            cmbDurumlar.TabIndex = 2;
            cmbDurumlar.SelectedIndexChanged += cmbDurumlar_SelectedIndexChanged;
            // 
            // cmbMevcutDurumlar
            // 
            cmbMevcutDurumlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMevcutDurumlar.FormattingEnabled = true;
            cmbMevcutDurumlar.Location = new Point(407, 296);
            cmbMevcutDurumlar.Name = "cmbMevcutDurumlar";
            cmbMevcutDurumlar.Size = new Size(459, 28);
            cmbMevcutDurumlar.TabIndex = 2;
            // 
            // cmbRenkler
            // 
            cmbRenkler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRenkler.FormattingEnabled = true;
            cmbRenkler.Location = new Point(407, 382);
            cmbRenkler.Name = "cmbRenkler";
            cmbRenkler.Size = new Size(459, 28);
            cmbRenkler.TabIndex = 2;
            // 
            // btnSatisRaporu
            // 
            btnSatisRaporu.Location = new Point(389, 461);
            btnSatisRaporu.Name = "btnSatisRaporu";
            btnSatisRaporu.Size = new Size(136, 29);
            btnSatisRaporu.TabIndex = 4;
            btnSatisRaporu.Text = "Satış Raporu";
            btnSatisRaporu.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(540, 461);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(136, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(691, 461);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(136, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(850, 461);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(136, 29);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // FRMAracIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 953);
            Controls.Add(lstvAracIslemler);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnSatisRaporu);
            Controls.Add(btnKiraRaporu);
            Controls.Add(nudKmBilgisi);
            Controls.Add(nudYilBilgisi);
            Controls.Add(cmbMevcutDurumlar);
            Controls.Add(cmbDurumlar);
            Controls.Add(cmbSanzimanTipleri);
            Controls.Add(cmbYakitTurleri);
            Controls.Add(cmbRenkler);
            Controls.Add(cmbKategoriler);
            Controls.Add(txtModelBilgisi);
            Controls.Add(txtMarkaBilgisi);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMAracIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMAracIslemleri";
            Load += FRMAracIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)nudYilBilgisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKmBilgisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMarkaBilgisi;
        private ComboBox cmbKategoriler;
        private NumericUpDown nudYilBilgisi;
        private Button btnKiraRaporu;
        private ListView lstvAracIslemler;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtModelBilgisi;
        private NumericUpDown nudKmBilgisi;
        private ComboBox cmbYakitTurleri;
        private ComboBox cmbSanzimanTipleri;
        private ComboBox cmbDurumlar;
        private ComboBox cmbMevcutDurumlar;
        private ComboBox cmbRenkler;
        private Button btnSatisRaporu;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
    }
}