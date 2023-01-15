namespace KuruTemizlemeOtomasyon
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.listboxUrunler = new System.Windows.Forms.ListBox();
            this.btnListeyeEkle = new System.Windows.Forms.Button();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.labbael2 = new System.Windows.Forms.Label();
            this.cbOdemeYapildi = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTeslimTarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cboxUrun = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxUrunler
            // 
            this.listboxUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listboxUrunler.FormattingEnabled = true;
            this.listboxUrunler.ItemHeight = 20;
            this.listboxUrunler.Location = new System.Drawing.Point(365, 12);
            this.listboxUrunler.Name = "listboxUrunler";
            this.listboxUrunler.Size = new System.Drawing.Size(202, 464);
            this.listboxUrunler.TabIndex = 0;
            // 
            // btnListeyeEkle
            // 
            this.btnListeyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnListeyeEkle.Image")));
            this.btnListeyeEkle.Location = new System.Drawing.Point(294, 65);
            this.btnListeyeEkle.Name = "btnListeyeEkle";
            this.btnListeyeEkle.Size = new System.Drawing.Size(50, 50);
            this.btnListeyeEkle.TabIndex = 1;
            this.btnListeyeEkle.UseVisualStyleBackColor = true;
            this.btnListeyeEkle.Click += new System.EventHandler(this.btnListeyeEkle_Click);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(558, 479);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(0, 20);
            this.lblToplamFiyat.TabIndex = 2;
            // 
            // labbael2
            // 
            this.labbael2.AutoSize = true;
            this.labbael2.Location = new System.Drawing.Point(365, 479);
            this.labbael2.Name = "labbael2";
            this.labbael2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labbael2.Size = new System.Drawing.Size(101, 20);
            this.labbael2.TabIndex = 3;
            this.labbael2.Text = "Toplam Fiyat: ";
            // 
            // cbOdemeYapildi
            // 
            this.cbOdemeYapildi.AutoSize = true;
            this.cbOdemeYapildi.Location = new System.Drawing.Point(34, 317);
            this.cbOdemeYapildi.Name = "cbOdemeYapildi";
            this.cbOdemeYapildi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbOdemeYapildi.Size = new System.Drawing.Size(129, 24);
            this.cbOdemeYapildi.TabIndex = 12;
            this.cbOdemeYapildi.Text = "Ödeme Yapıldı";
            this.cbOdemeYapildi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1576, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTeslimTarih
            // 
            this.lblTeslimTarih.AutoSize = true;
            this.lblTeslimTarih.Location = new System.Drawing.Point(32, 267);
            this.lblTeslimTarih.Name = "lblTeslimTarih";
            this.lblTeslimTarih.Size = new System.Drawing.Size(109, 20);
            this.lblTeslimTarih.TabIndex = 16;
            this.lblTeslimTarih.Text = "TESLİM TARİHİ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 27);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(34, 199);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(271, 28);
            this.cbMusteriler.TabIndex = 19;
            this.cbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cbMusteriler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "MÜŞTERİ LİSTESİ";
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOnayla.Location = new System.Drawing.Point(32, 366);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(273, 89);
            this.btnOnayla.TabIndex = 21;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(294, 134);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 50);
            this.btnSil.TabIndex = 22;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cboxUrun
            // 
            this.cboxUrun.FormattingEnabled = true;
            this.cboxUrun.Location = new System.Drawing.Point(34, 32);
            this.cboxUrun.Name = "cboxUrun";
            this.cboxUrun.Size = new System.Drawing.Size(193, 28);
            this.cboxUrun.TabIndex = 23;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(250, 32);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(94, 27);
            this.nudAdet.TabIndex = 24;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ÜRÜN SEÇİNİZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "ADET";
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboxUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMusteriler);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTeslimTarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbOdemeYapildi);
            this.Controls.Add(this.labbael2);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.btnListeyeEkle);
            this.Controls.Add(this.listboxUrunler);
            this.Name = "MusteriEkle";
            this.Text = "SIPARIS EKLE";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listboxUrunler;
        private Button btnListeyeEkle;
        private Label lblToplamFiyat;
        private Label labbael2;
        private CheckBox cbOdemeYapildi;
        private Button button1;
        private Label lblTeslimTarih;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbMusteriler;
        private Label label1;
        private Button btnOnayla;
        private Button btnSil;
        private ComboBox cboxUrun;
        private NumericUpDown nudAdet;
        private Label label2;
        private Label label3;
    }
}