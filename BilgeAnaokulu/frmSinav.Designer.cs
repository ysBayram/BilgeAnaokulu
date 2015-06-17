namespace BilgeAnaokulu
{
    partial class frmSinav
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
            this.cmbSinav = new MetroFramework.Controls.MetroComboBox();
            this.lblSinav = new MetroFramework.Controls.MetroLabel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlSinav = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSinav
            // 
            this.cmbSinav.FormattingEnabled = true;
            this.cmbSinav.ItemHeight = 23;
            this.cmbSinav.Location = new System.Drawing.Point(64, 5);
            this.cmbSinav.Name = "cmbSinav";
            this.cmbSinav.Size = new System.Drawing.Size(160, 29);
            this.cmbSinav.TabIndex = 0;
            this.cmbSinav.SelectedIndexChanged += new System.EventHandler(this.cmbSinav_SelectedIndexChanged);
            // 
            // lblSinav
            // 
            this.lblSinav.AutoSize = true;
            this.lblSinav.Location = new System.Drawing.Point(3, 10);
            this.lblSinav.Name = "lblSinav";
            this.lblSinav.Size = new System.Drawing.Size(39, 19);
            this.lblSinav.TabIndex = 1;
            this.lblSinav.Text = "Sınav";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cmbSinav);
            this.pnlTop.Controls.Add(this.lblSinav);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(20, 60);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(660, 39);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlSinav
            // 
            this.pnlSinav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSinav.Location = new System.Drawing.Point(20, 99);
            this.pnlSinav.Name = "pnlSinav";
            this.pnlSinav.Size = new System.Drawing.Size(660, 231);
            this.pnlSinav.TabIndex = 3;
            // 
            // frmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.pnlSinav);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmSinav";
            this.Resizable = false;
            this.Text = "Sınav Göster";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbSinav;
        private MetroFramework.Controls.MetroLabel lblSinav;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlSinav;
    }
}