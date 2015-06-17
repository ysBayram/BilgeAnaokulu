namespace BilgeAnaokulu.UserController
{
    partial class ucEgitmen
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
            this.txtTCKimlikNo = new MetroFramework.Controls.MetroTextBox();
            this.cmbKanGrup = new MetroFramework.Controls.MetroComboBox();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.txtSoyad = new MetroFramework.Controls.MetroTextBox();
            this.lblKan = new System.Windows.Forms.Label();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(165, 12);
            this.txtTCKimlikNo.MaxLength = 11;
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(209, 23);
            this.txtTCKimlikNo.TabIndex = 0;
            this.txtTCKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCKimlikNo_KeyPress);
            // 
            // cmbKanGrup
            // 
            this.cmbKanGrup.FormattingEnabled = true;
            this.cmbKanGrup.ItemHeight = 23;
            this.cmbKanGrup.Location = new System.Drawing.Point(165, 170);
            this.cmbKanGrup.Name = "cmbKanGrup";
            this.cmbKanGrup.Size = new System.Drawing.Size(209, 29);
            this.cmbKanGrup.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(165, 139);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(209, 23);
            this.txtAdres.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(165, 107);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(209, 23);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblKan
            // 
            this.lblKan.AutoSize = true;
            this.lblKan.Location = new System.Drawing.Point(20, 185);
            this.lblKan.Name = "lblKan";
            this.lblKan.Size = new System.Drawing.Size(58, 13);
            this.lblKan.TabIndex = 20;
            this.lblKan.Text = "Kan Grubu";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(165, 75);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(209, 23);
            this.txtAd.TabIndex = 1;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(20, 147);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 15;
            this.lblAdres.Text = "Adres";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(20, 114);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 13;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(21, 17);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(68, 13);
            this.lblTcKimlik.TabIndex = 22;
            this.lblTcKimlik.Text = "TC Kimlik No";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 81);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(20, 50);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 12;
            this.lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(165, 44);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(209, 23);
            this.txtSifre.TabIndex = 1;
            // 
            // ucEgitmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.cmbKanGrup);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblKan);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTcKimlik);
            this.Controls.Add(this.lblAd);
            this.Name = "ucEgitmen";
            this.Size = new System.Drawing.Size(394, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTCKimlikNo;
        private MetroFramework.Controls.MetroComboBox cmbKanGrup;
        private MetroFramework.Controls.MetroTextBox txtAdres;
        private MetroFramework.Controls.MetroTextBox txtSoyad;
        private System.Windows.Forms.Label lblKan;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSifre;
        private MetroFramework.Controls.MetroTextBox txtSifre;
    }
}
