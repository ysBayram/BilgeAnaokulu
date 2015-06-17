namespace BilgeAnaokulu.UserController
{
    partial class ucDers
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
            this.txtIcerik = new MetroFramework.Controls.MetroTextBox();
            this.cmbEgitmen = new MetroFramework.Controls.MetroComboBox();
            this.cmbSinif = new MetroFramework.Controls.MetroComboBox();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.lblEgitmen = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblBitisZaman = new System.Windows.Forms.Label();
            this.lblBaslamaZaman = new System.Windows.Forms.Label();
            this.dtpBaslama = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(161, 45);
            this.txtIcerik.MaxLength = 10;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(209, 23);
            this.txtIcerik.TabIndex = 19;
            // 
            // cmbEgitmen
            // 
            this.cmbEgitmen.FormattingEnabled = true;
            this.cmbEgitmen.ItemHeight = 23;
            this.cmbEgitmen.Location = new System.Drawing.Point(161, 177);
            this.cmbEgitmen.Name = "cmbEgitmen";
            this.cmbEgitmen.Size = new System.Drawing.Size(209, 29);
            this.cmbEgitmen.TabIndex = 24;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.ItemHeight = 23;
            this.cmbSinif.Location = new System.Drawing.Point(161, 138);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(209, 29);
            this.cmbSinif.TabIndex = 23;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(161, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(209, 23);
            this.txtAd.TabIndex = 18;
            // 
            // lblEgitmen
            // 
            this.lblEgitmen.AutoSize = true;
            this.lblEgitmen.Location = new System.Drawing.Point(16, 185);
            this.lblEgitmen.Name = "lblEgitmen";
            this.lblEgitmen.Size = new System.Drawing.Size(47, 13);
            this.lblEgitmen.TabIndex = 11;
            this.lblEgitmen.Text = "Eğitmeni";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(16, 146);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(29, 13);
            this.lblSinif.TabIndex = 13;
            this.lblSinif.Text = "Sınıfı";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(16, 50);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(33, 13);
            this.lblIcerik.TabIndex = 15;
            this.lblIcerik.Text = "İçerik";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(16, 17);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 17;
            this.lblAd.Text = "Ad";
            // 
            // lblBitisZaman
            // 
            this.lblBitisZaman.AutoSize = true;
            this.lblBitisZaman.Location = new System.Drawing.Point(16, 112);
            this.lblBitisZaman.Name = "lblBitisZaman";
            this.lblBitisZaman.Size = new System.Drawing.Size(64, 13);
            this.lblBitisZaman.TabIndex = 16;
            this.lblBitisZaman.Text = "Bitiş Zamanı";
            // 
            // lblBaslamaZaman
            // 
            this.lblBaslamaZaman.AutoSize = true;
            this.lblBaslamaZaman.Location = new System.Drawing.Point(16, 82);
            this.lblBaslamaZaman.Name = "lblBaslamaZaman";
            this.lblBaslamaZaman.Size = new System.Drawing.Size(85, 13);
            this.lblBaslamaZaman.TabIndex = 12;
            this.lblBaslamaZaman.Text = "Başlama Zamanı";
            // 
            // dtpBaslama
            // 
            this.dtpBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBaslama.Location = new System.Drawing.Point(161, 78);
            this.dtpBaslama.Name = "dtpBaslama";
            this.dtpBaslama.Size = new System.Drawing.Size(209, 20);
            this.dtpBaslama.TabIndex = 25;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBitis.Location = new System.Drawing.Point(161, 108);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(209, 20);
            this.dtpBitis.TabIndex = 25;
            // 
            // ucDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslama);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.cmbEgitmen);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblEgitmen);
            this.Controls.Add(this.lblBaslamaZaman);
            this.Controls.Add(this.lblSinif);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblBitisZaman);
            this.Controls.Add(this.lblAd);
            this.Name = "ucDers";
            this.Size = new System.Drawing.Size(384, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtIcerik;
        private MetroFramework.Controls.MetroComboBox cmbEgitmen;
        private MetroFramework.Controls.MetroComboBox cmbSinif;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private System.Windows.Forms.Label lblEgitmen;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblBitisZaman;
        private System.Windows.Forms.Label lblBaslamaZaman;
        private System.Windows.Forms.DateTimePicker dtpBaslama;
        private System.Windows.Forms.DateTimePicker dtpBitis;
    }
}
