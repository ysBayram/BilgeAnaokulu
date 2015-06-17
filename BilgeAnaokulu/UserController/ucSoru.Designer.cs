namespace BilgeAnaokulu.UserController
{
    partial class ucSoru
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
            this.cmbDSec = new MetroFramework.Controls.MetroComboBox();
            this.cmbSinav = new MetroFramework.Controls.MetroComboBox();
            this.txtPuan = new MetroFramework.Controls.MetroTextBox();
            this.txtIcerik = new MetroFramework.Controls.MetroTextBox();
            this.lblDSec = new System.Windows.Forms.Label();
            this.lblSinav = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtSoruNo = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cmbDSec
            // 
            this.cmbDSec.FormattingEnabled = true;
            this.cmbDSec.ItemHeight = 23;
            this.cmbDSec.Location = new System.Drawing.Point(162, 147);
            this.cmbDSec.Name = "cmbDSec";
            this.cmbDSec.Size = new System.Drawing.Size(209, 29);
            this.cmbDSec.TabIndex = 3;
            // 
            // cmbSinav
            // 
            this.cmbSinav.FormattingEnabled = true;
            this.cmbSinav.ItemHeight = 23;
            this.cmbSinav.Location = new System.Drawing.Point(162, 109);
            this.cmbSinav.Name = "cmbSinav";
            this.cmbSinav.Size = new System.Drawing.Size(209, 29);
            this.cmbSinav.TabIndex = 2;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(162, 77);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.ReadOnly = true;
            this.txtPuan.Size = new System.Drawing.Size(209, 23);
            this.txtPuan.TabIndex = 1;
            this.txtPuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuan_KeyPress);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(162, 13);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.ReadOnly = true;
            this.txtIcerik.Size = new System.Drawing.Size(209, 23);
            this.txtIcerik.TabIndex = 0;
            // 
            // lblDSec
            // 
            this.lblDSec.AutoSize = true;
            this.lblDSec.Location = new System.Drawing.Point(17, 155);
            this.lblDSec.Name = "lblDSec";
            this.lblDSec.Size = new System.Drawing.Size(82, 13);
            this.lblDSec.TabIndex = 11;
            this.lblDSec.Text = "Doğru Seçenek";
            // 
            // lblSinav
            // 
            this.lblSinav.AutoSize = true;
            this.lblSinav.Location = new System.Drawing.Point(17, 120);
            this.lblSinav.Name = "lblSinav";
            this.lblSinav.Size = new System.Drawing.Size(34, 13);
            this.lblSinav.TabIndex = 12;
            this.lblSinav.Text = "Sinav";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(17, 85);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(32, 13);
            this.lblPuan.TabIndex = 13;
            this.lblPuan.Text = "Puan";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(17, 18);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(33, 13);
            this.lblIcerik.TabIndex = 14;
            this.lblIcerik.Text = "İçerik";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(17, 53);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(76, 13);
            this.lblNo.TabIndex = 13;
            this.lblNo.Text = "Soru Numarası";
            // 
            // txtSoruNo
            // 
            this.txtSoruNo.Location = new System.Drawing.Point(162, 45);
            this.txtSoruNo.Name = "txtSoruNo";
            this.txtSoruNo.ReadOnly = true;
            this.txtSoruNo.Size = new System.Drawing.Size(209, 23);
            this.txtSoruNo.TabIndex = 1;
            this.txtSoruNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoruNo_KeyPress);
            // 
            // ucSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDSec);
            this.Controls.Add(this.cmbSinav);
            this.Controls.Add(this.txtSoruNo);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.lblDSec);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblSinav);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblIcerik);
            this.Name = "ucSoru";
            this.Size = new System.Drawing.Size(395, 202);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbDSec;
        private MetroFramework.Controls.MetroComboBox cmbSinav;
        private MetroFramework.Controls.MetroTextBox txtPuan;
        private MetroFramework.Controls.MetroTextBox txtIcerik;
        private System.Windows.Forms.Label lblDSec;
        private System.Windows.Forms.Label lblSinav;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblNo;
        private MetroFramework.Controls.MetroTextBox txtSoruNo;
    }
}
