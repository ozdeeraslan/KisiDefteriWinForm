namespace WinFormOOPGorev
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAd = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            btnEkle = new Button();
            lstKisiler = new ListBox();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnYukari = new Button();
            btnAsagi = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(24, 24);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(24, 66);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(196, 66);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(196, 24);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(356, 65);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstKisiler
            // 
            lstKisiler.DisplayMember = "TamAd";
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 20;
            lstKisiler.Location = new Point(26, 127);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(376, 224);
            lstKisiler.TabIndex = 5;
            lstKisiler.KeyDown += lstKisiler_KeyDown;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(26, 376);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(94, 29);
            btnDuzenle.TabIndex = 6;
            btnDuzenle.Text = "DUZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(140, 376);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 7;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(419, 192);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(31, 29);
            btnYukari.TabIndex = 8;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(419, 241);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(31, 29);
            btnAsagi.TabIndex = 9;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(btnAsagi);
            Controls.Add(btnYukari);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(lstKisiler);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Kisi Defteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblSoyad;
        private Button btnEkle;
        private ListBox lstKisiler;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnYukari;
        private Button btnAsagi;
    }
}