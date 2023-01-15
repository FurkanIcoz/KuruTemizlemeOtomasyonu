namespace KuruTemizlemeOtomasyon
{
    partial class TeslimEdilenÜrünler
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
            this.dgwTesEdilenU = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTesEdilenU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTesEdilenU
            // 
            this.dgwTesEdilenU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwTesEdilenU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTesEdilenU.Location = new System.Drawing.Point(0, 3);
            this.dgwTesEdilenU.Name = "dgwTesEdilenU";
            this.dgwTesEdilenU.RowHeadersWidth = 51;
            this.dgwTesEdilenU.Size = new System.Drawing.Size(1439, 465);
            this.dgwTesEdilenU.TabIndex = 0;
            // 
            // TeslimEdilenÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 472);
            this.Controls.Add(this.dgwTesEdilenU);
            this.Name = "TeslimEdilenÜrünler";
            this.Text = "TeslimEdilenÜrünler";
            this.Load += new System.EventHandler(this.TeslimEdilenÜrünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTesEdilenU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwTesEdilenU;
    }
}