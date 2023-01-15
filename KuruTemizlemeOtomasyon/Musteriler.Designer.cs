namespace KuruTemizlemeOtomasyon
{
    partial class Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.lblMusteriSayi = new System.Windows.Forms.Label();
            this.lblMSayi = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Location = new System.Drawing.Point(12, 22);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.RowHeadersWidth = 51;
            this.dgwMusteriler.RowTemplate.Height = 29;
            this.dgwMusteriler.Size = new System.Drawing.Size(798, 298);
            this.dgwMusteriler.TabIndex = 0;
            // 
            // lblMusteriSayi
            // 
            this.lblMusteriSayi.AutoSize = true;
            this.lblMusteriSayi.Location = new System.Drawing.Point(738, 323);
            this.lblMusteriSayi.Name = "lblMusteriSayi";
            this.lblMusteriSayi.Size = new System.Drawing.Size(50, 20);
            this.lblMusteriSayi.TabIndex = 1;
            this.lblMusteriSayi.Text = "label1";
            // 
            // lblMSayi
            // 
            this.lblMSayi.AutoSize = true;
            this.lblMSayi.Location = new System.Drawing.Point(630, 323);
            this.lblMSayi.Name = "lblMSayi";
            this.lblMSayi.Size = new System.Drawing.Size(102, 20);
            this.lblMSayi.TabIndex = 2;
            this.lblMSayi.Text = "Müşteri Sayisi:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusteriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.Location = new System.Drawing.Point(816, 22);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(98, 298);
            this.btnMusteriEkle.TabIndex = 3;
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(73, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "YENİLE";
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(926, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.lblMSayi);
            this.Controls.Add(this.lblMusteriSayi);
            this.Controls.Add(this.dgwMusteriler);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgwMusteriler;
        private Label lblMusteriSayi;
        private Label lblMSayi;
        private Button btnMusteriEkle;
        private Button button1;
        private Label label1;
    }
}