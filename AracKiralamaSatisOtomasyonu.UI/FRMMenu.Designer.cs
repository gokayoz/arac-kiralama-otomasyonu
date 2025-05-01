namespace AracKiralamaSatisOtomasyonu.UI
{
    partial class FRMMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAracIslem = new Button();
            button2 = new Button();
            button3 = new Button();
            btnMusteriIslem = new Button();
            SuspendLayout();
            // 
            // btnAracIslem
            // 
            btnAracIslem.Location = new Point(148, 153);
            btnAracIslem.Name = "btnAracIslem";
            btnAracIslem.Size = new Size(118, 103);
            btnAracIslem.TabIndex = 0;
            btnAracIslem.Text = "Araç İşlemleri";
            btnAracIslem.UseVisualStyleBackColor = true;
            btnAracIslem.Click += btnAracIslem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(278, 153);
            button2.Name = "button2";
            button2.Size = new Size(118, 103);
            button2.TabIndex = 0;
            button2.Text = "Kiralama İşlemleri";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(405, 153);
            button3.Name = "button3";
            button3.Size = new Size(118, 103);
            button3.TabIndex = 0;
            button3.Text = "Satış İşlemleri";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnMusteriIslem
            // 
            btnMusteriIslem.Location = new Point(535, 153);
            btnMusteriIslem.Name = "btnMusteriIslem";
            btnMusteriIslem.Size = new Size(118, 103);
            btnMusteriIslem.TabIndex = 0;
            btnMusteriIslem.Text = "Müşteri İşlemleri";
            btnMusteriIslem.UseVisualStyleBackColor = true;
            btnMusteriIslem.Click += btnMusteriIslem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMusteriIslem);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAracIslem);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAracIslem;
        private Button button2;
        private Button button3;
        private Button btnMusteriIslem;
    }
}
