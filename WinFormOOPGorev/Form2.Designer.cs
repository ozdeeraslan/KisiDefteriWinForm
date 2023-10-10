namespace WinFormOOPGorev
{
    partial class Form2
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
            lblAd = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(31, 38);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(35, 83);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(188, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(35, 197);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(188, 27);
            txtSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(31, 152);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(31, 263);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(84, 29);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(147, 263);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(76, 29);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "IPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 334);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Düzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblSoyad;
        private Button btnKaydet;
        private Button btnIptal;
    }
}