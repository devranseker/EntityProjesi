namespace EntityProjesi
{
    partial class FrmAnaForm
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
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnIstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(12, 12);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(158, 109);
            this.BtnKategori.TabIndex = 0;
            this.BtnKategori.Text = "Kategori İşlemleri";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Location = new System.Drawing.Point(176, 12);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(158, 109);
            this.BtnUrun.TabIndex = 1;
            this.BtnUrun.Text = "Ürün İşlemleri";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Location = new System.Drawing.Point(340, 12);
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.Size = new System.Drawing.Size(158, 109);
            this.BtnIstatistik.TabIndex = 2;
            this.BtnIstatistik.Text = "İstatistikler";
            this.BtnIstatistik.UseVisualStyleBackColor = true;
            this.BtnIstatistik.Click += new System.EventHandler(this.BtnIstatistik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(513, 145);
            this.Controls.Add(this.BtnIstatistik);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnIstatistik;
    }
}