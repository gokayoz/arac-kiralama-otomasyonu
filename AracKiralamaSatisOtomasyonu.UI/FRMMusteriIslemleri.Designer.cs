namespace AracKiralamaSatisOtomasyonu.UI
{
    partial class FRMMusteriIslemleri
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
            txtAdSoyad = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            lstvMusteriler = new ListView();
            txtTelefon = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtAdres = new TextBox();
            label4 = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(255, 32);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(349, 27);
            txtAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(204, 279);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 28);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstvMusteriler
            // 
            lstvMusteriler.Location = new Point(12, 341);
            lstvMusteriler.Name = "lstvMusteriler";
            lstvMusteriler.Size = new Size(758, 400);
            lstvMusteriler.TabIndex = 3;
            lstvMusteriler.UseCompatibleStateImageBehavior = false;
            lstvMusteriler.DoubleClick += lstvMusteriler_DoubleClick;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(255, 79);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(349, 27);
            txtTelefon.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 79);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 27);
            txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 125);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Eposta:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(255, 172);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(349, 68);
            txtAdres.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 172);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "Adres:";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(341, 279);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 28);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(476, 279);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 28);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // FRMMusteriIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(lstvMusteriler);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(txtAdres);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtTelefon);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Name = "FRMMusteriIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMMusteriIslemleri";
            Load += FRMMusteriIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private Label label1;
        private Button btnEkle;
        private ListView lstvMusteriler;
        private TextBox txtTelefon;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtAdres;
        private Label label4;
        private Button btnSil;
        private Button btnGuncelle;
    }
}