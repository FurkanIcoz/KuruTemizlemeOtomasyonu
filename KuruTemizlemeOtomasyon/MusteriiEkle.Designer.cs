namespace KuruTemizlemeOtomasyon
{
    partial class MusteriiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriiEkle));
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.txtMstrAdres = new System.Windows.Forms.TextBox();
            this.txtMstrTel = new System.Windows.Forms.TextBox();
            this.txtMstrSoyad = new System.Windows.Forms.TextBox();
            this.txtMstrAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(45, 155);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 15);
            this.lblAdres.TabIndex = 19;
            this.lblAdres.Text = "ADRES:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(45, 104);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 15);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "TELEFON:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(45, 66);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 15);
            this.lblSoyad.TabIndex = 17;
            this.lblSoyad.Text = "SOYAD:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(45, 29);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(26, 15);
            this.lblIsim.TabIndex = 16;
            this.lblIsim.Text = "AD:";
            // 
            // txtMstrAdres
            // 
            this.txtMstrAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMstrAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMstrAdres.Location = new System.Drawing.Point(143, 152);
            this.txtMstrAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMstrAdres.Multiline = true;
            this.txtMstrAdres.Name = "txtMstrAdres";
            this.txtMstrAdres.Size = new System.Drawing.Size(110, 74);
            this.txtMstrAdres.TabIndex = 15;
            // 
            // txtMstrTel
            // 
            this.txtMstrTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMstrTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMstrTel.Location = new System.Drawing.Point(143, 102);
            this.txtMstrTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMstrTel.MaxLength = 10;
            this.txtMstrTel.Name = "txtMstrTel";
            this.txtMstrTel.Size = new System.Drawing.Size(110, 23);
            this.txtMstrTel.TabIndex = 14;
            this.txtMstrTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMstrTel_KeyPress);
            // 
            // txtMstrSoyad
            // 
            this.txtMstrSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMstrSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMstrSoyad.Location = new System.Drawing.Point(143, 64);
            this.txtMstrSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMstrSoyad.Name = "txtMstrSoyad";
            this.txtMstrSoyad.Size = new System.Drawing.Size(110, 23);
            this.txtMstrSoyad.TabIndex = 13;
            // 
            // txtMstrAd
            // 
            this.txtMstrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMstrAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMstrAd.Location = new System.Drawing.Point(143, 26);
            this.txtMstrAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMstrAd.Name = "txtMstrAd";
            this.txtMstrAd.Size = new System.Drawing.Size(110, 23);
            this.txtMstrAd.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(305, 90);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(158, 135);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // MusteriiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(473, 243);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtMstrAdres);
            this.Controls.Add(this.txtMstrTel);
            this.Controls.Add(this.txtMstrSoyad);
            this.Controls.Add(this.txtMstrAd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MusteriiEkle";
            this.Text = "Musteri Ekle";
            this.Load += new System.EventHandler(this.MusteriiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAdres;
        private Label lblTel;
        private Label lblSoyad;
        private Label lblIsim;
        private TextBox txtMstrAdres;
        private TextBox txtMstrTel;
        private TextBox txtMstrSoyad;
        private TextBox txtMstrAd;
        private Button btnKaydet;
    }
}