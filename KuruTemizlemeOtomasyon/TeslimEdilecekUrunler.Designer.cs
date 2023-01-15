namespace KuruTemizlemeOtomasyon
{
    partial class TeslimEdilecekUrunler
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
            this.dgwTeslimEu = new System.Windows.Forms.DataGridView();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnHazir = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeslimEu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTeslimEu
            // 
            this.dgwTeslimEu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwTeslimEu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwTeslimEu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeslimEu.Location = new System.Drawing.Point(12, 12);
            this.dgwTeslimEu.Name = "dgwTeslimEu";
            this.dgwTeslimEu.RowHeadersWidth = 51;
            this.dgwTeslimEu.RowTemplate.Height = 29;
            this.dgwTeslimEu.Size = new System.Drawing.Size(1553, 426);
            this.dgwTeslimEu.TabIndex = 0;
            // 
            // btnOku
            // 
            this.btnOku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOku.Location = new System.Drawing.Point(1589, 48);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(107, 89);
            this.btnOku.TabIndex = 1;
            this.btnOku.Text = "TESLİM ET";
            this.btnOku.UseVisualStyleBackColor = false;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnHazir
            // 
            this.btnHazir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHazir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHazir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHazir.Location = new System.Drawing.Point(1589, 160);
            this.btnHazir.Name = "btnHazir";
            this.btnHazir.Size = new System.Drawing.Size(107, 89);
            this.btnHazir.TabIndex = 2;
            this.btnHazir.Text = "HAZIR";
            this.btnHazir.UseVisualStyleBackColor = false;
            this.btnHazir.Click += new System.EventHandler(this.btnHazir_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOdemeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdemeAl.Location = new System.Drawing.Point(1589, 274);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(107, 89);
            this.btnOdemeAl.TabIndex = 3;
            this.btnOdemeAl.Text = "ÖDENDİ";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // TeslimEdilecekUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1701, 448);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnHazir);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.dgwTeslimEu);
            this.Name = "TeslimEdilecekUrunler";
            this.Text = "TeslimEdilecekUrunler";
            this.Load += new System.EventHandler(this.TeslimEdilecekUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeslimEu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwTeslimEu;
        private Button btnOku;
        private Button btnHazir;
        private Button btnOdemeAl;
    }
}