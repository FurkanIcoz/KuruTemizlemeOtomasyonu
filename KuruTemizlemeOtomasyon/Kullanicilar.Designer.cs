namespace KuruTemizlemeOtomasyon
{
    partial class Kullanicilar
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
            this.dgwKullanicilar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKullanicilar
            // 
            this.dgwKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.dgwKullanicilar.Name = "dgwKullanicilar";
            this.dgwKullanicilar.RowHeadersWidth = 51;
            this.dgwKullanicilar.RowTemplate.Height = 29;
            this.dgwKullanicilar.Size = new System.Drawing.Size(934, 284);
            this.dgwKullanicilar.TabIndex = 0;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(958, 309);
            this.Controls.Add(this.dgwKullanicilar);
            this.Name = "Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwKullanicilar;
    }
}