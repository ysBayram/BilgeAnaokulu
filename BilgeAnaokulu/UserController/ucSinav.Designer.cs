namespace BilgeAnaokulu.UserController
{
    partial class ucSinav
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.txtPuan = new MetroFramework.Controls.MetroTextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangicZaman = new System.Windows.Forms.Label();
            this.lblBitisZaman = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblEgitmen = new System.Windows.Forms.Label();
            this.lblDers = new System.Windows.Forms.Label();
            this.lblsinif = new System.Windows.Forms.Label();
            this.cmbEgitmen = new MetroFramework.Controls.MetroComboBox();
            this.cmbDers = new MetroFramework.Controls.MetroComboBox();
            this.cmbSinif = new MetroFramework.Controls.MetroComboBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtSure = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(22, 26);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(141, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 23);
            this.txtAd.TabIndex = 1;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(22, 63);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(32, 13);
            this.lblPuan.TabIndex = 0;
            this.lblPuan.Text = "Puan";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(141, 58);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(200, 23);
            this.txtPuan.TabIndex = 1;
            this.txtPuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuan_KeyPress);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(141, 129);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // lblBaslangicZaman
            // 
            this.lblBaslangicZaman.AutoSize = true;
            this.lblBaslangicZaman.Location = new System.Drawing.Point(22, 133);
            this.lblBaslangicZaman.Name = "lblBaslangicZaman";
            this.lblBaslangicZaman.Size = new System.Drawing.Size(91, 13);
            this.lblBaslangicZaman.TabIndex = 0;
            this.lblBaslangicZaman.Text = "Başlangıç Zamanı";
            // 
            // lblBitisZaman
            // 
            this.lblBitisZaman.AutoSize = true;
            this.lblBitisZaman.Location = new System.Drawing.Point(22, 167);
            this.lblBitisZaman.Name = "lblBitisZaman";
            this.lblBitisZaman.Size = new System.Drawing.Size(64, 13);
            this.lblBitisZaman.TabIndex = 0;
            this.lblBitisZaman.Text = "Bitiş Zamanı";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(141, 163);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 2;
            // 
            // lblEgitmen
            // 
            this.lblEgitmen.AutoSize = true;
            this.lblEgitmen.Location = new System.Drawing.Point(22, 205);
            this.lblEgitmen.Name = "lblEgitmen";
            this.lblEgitmen.Size = new System.Drawing.Size(45, 13);
            this.lblEgitmen.TabIndex = 0;
            this.lblEgitmen.Text = "Eğitmen";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(22, 248);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(29, 13);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders";
            // 
            // lblsinif
            // 
            this.lblsinif.AutoSize = true;
            this.lblsinif.Location = new System.Drawing.Point(22, 291);
            this.lblsinif.Name = "lblsinif";
            this.lblsinif.Size = new System.Drawing.Size(27, 13);
            this.lblsinif.TabIndex = 0;
            this.lblsinif.Text = "Sınıf";
            // 
            // cmbEgitmen
            // 
            this.cmbEgitmen.FormattingEnabled = true;
            this.cmbEgitmen.ItemHeight = 23;
            this.cmbEgitmen.Location = new System.Drawing.Point(141, 197);
            this.cmbEgitmen.Name = "cmbEgitmen";
            this.cmbEgitmen.Size = new System.Drawing.Size(200, 29);
            this.cmbEgitmen.TabIndex = 3;
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.ItemHeight = 23;
            this.cmbDers.Location = new System.Drawing.Point(141, 240);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(200, 29);
            this.cmbDers.TabIndex = 3;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.ItemHeight = 23;
            this.cmbSinif.Location = new System.Drawing.Point(141, 283);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(200, 29);
            this.cmbSinif.TabIndex = 3;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(22, 99);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(50, 13);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "Süre (dk)";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(141, 94);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(200, 23);
            this.txtSure.TabIndex = 1;
            this.txtSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSure_KeyPress);
            // 
            // ucSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.cmbEgitmen);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblsinif);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.lblEgitmen);
            this.Controls.Add(this.lblBitisZaman);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblBaslangicZaman);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Name = "ucSinav";
            this.Size = new System.Drawing.Size(371, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private System.Windows.Forms.Label lblPuan;
        private MetroFramework.Controls.MetroTextBox txtPuan;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBaslangicZaman;
        private System.Windows.Forms.Label lblBitisZaman;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblEgitmen;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.Label lblsinif;
        private MetroFramework.Controls.MetroComboBox cmbEgitmen;
        private MetroFramework.Controls.MetroComboBox cmbDers;
        private MetroFramework.Controls.MetroComboBox cmbSinif;
        private System.Windows.Forms.Label lblSure;
        private MetroFramework.Controls.MetroTextBox txtSure;
    }
}
