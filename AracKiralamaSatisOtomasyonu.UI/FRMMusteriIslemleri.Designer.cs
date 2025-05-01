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
            button1 = new Button();
            lstvMusteriler = new ListView();
            txtTelefon = new TextBox();
            label2 = new Label();
            txtEposta = new TextBox();
            label3 = new Label();
            txtAdres = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
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
            // button1
            // 
            button1.Location = new Point(204, 279);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // lstvMusteriler
            // 
            lstvMusteriler.Location = new Point(12, 341);
            lstvMusteriler.Name = "lstvMusteriler";
            lstvMusteriler.Size = new Size(758, 400);
            lstvMusteriler.TabIndex = 3;
            lstvMusteriler.UseCompatibleStateImageBehavior = false;
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
            // txtEposta
            // 
            txtEposta.Location = new Point(255, 125);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(349, 27);
            txtEposta.TabIndex = 0;
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
            // button2
            // 
            button2.Location = new Point(341, 279);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 2;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(476, 279);
            button3.Name = "button3";
            button3.Size = new Size(94, 28);
            button3.TabIndex = 2;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // FRMMusteriIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(lstvMusteriler);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtAdres);
            Controls.Add(label3);
            Controls.Add(txtEposta);
            Controls.Add(label2);
            Controls.Add(txtTelefon);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Name = "FRMMusteriIslemleri";
            Text = "FRMMusteriIslemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private Label label1;
        private Button button1;
        private ListView lstvMusteriler;
        private TextBox txtTelefon;
        private Label label2;
        private TextBox txtEposta;
        private Label label3;
        private TextBox txtAdres;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}