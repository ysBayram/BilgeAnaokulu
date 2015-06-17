namespace BilgeAnaokulu.UserController
{
    partial class ucYoklama
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblDevamDurum = new System.Windows.Forms.Label();
            this.tglDevamDurumu = new MetroFramework.Controls.MetroToggle();
            this.cmbOgrenci = new MetroFramework.Controls.MetroComboBox();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(176, 55);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 0;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(27, 61);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih";
            // 
            // lblDevamDurum
            // 
            this.lblDevamDurum.AutoSize = true;
            this.lblDevamDurum.Location = new System.Drawing.Point(27, 92);
            this.lblDevamDurum.Name = "lblDevamDurum";
            this.lblDevamDurum.Size = new System.Drawing.Size(81, 13);
            this.lblDevamDurum.TabIndex = 2;
            this.lblDevamDurum.Text = "Devam Durumu";
            // 
            // tglDevamDurumu
            // 
            this.tglDevamDurumu.AutoSize = true;
            this.tglDevamDurumu.Location = new System.Drawing.Point(176, 91);
            this.tglDevamDurumu.Name = "tglDevamDurumu";
            this.tglDevamDurumu.Size = new System.Drawing.Size(80, 17);
            this.tglDevamDurumu.TabIndex = 3;
            this.tglDevamDurumu.Text = "Devamsız";
            this.tglDevamDurumu.UseVisualStyleBackColor = true;
            this.tglDevamDurumu.CheckedChanged += new System.EventHandler(this.tglDevamDurumu_CheckedChanged);
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.ItemHeight = 23;
            this.cmbOgrenci.Location = new System.Drawing.Point(176, 16);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(200, 29);
            this.cmbOgrenci.TabIndex = 4;
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Location = new System.Drawing.Point(27, 23);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(44, 13);
            this.lblOgrenci.TabIndex = 5;
            this.lblOgrenci.Text = "Öğrenci";
            // 
            // ucYoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.cmbOgrenci);
            this.Controls.Add(this.tglDevamDurumu);
            this.Controls.Add(this.lblDevamDurum);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dtpTarih);
            this.Name = "ucYoklama";
            this.Size = new System.Drawing.Size(396, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDevamDurum;
        private MetroFramework.Controls.MetroToggle tglDevamDurumu;
        private MetroFramework.Controls.MetroComboBox cmbOgrenci;
        private System.Windows.Forms.Label lblOgrenci;
    }
}
