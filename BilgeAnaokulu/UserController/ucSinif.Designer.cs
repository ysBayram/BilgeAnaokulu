namespace BilgeAnaokulu.UserController
{
    partial class ucSinif
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
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSube = new System.Windows.Forms.Label();
            this.txtSube = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(172, 15);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(209, 23);
            this.txtAd.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(27, 20);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad";
            // 
            // lblSube
            // 
            this.lblSube.AutoSize = true;
            this.lblSube.Location = new System.Drawing.Point(27, 52);
            this.lblSube.Name = "lblSube";
            this.lblSube.Size = new System.Drawing.Size(32, 13);
            this.lblSube.TabIndex = 2;
            this.lblSube.Text = "Şube";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(172, 47);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(209, 23);
            this.txtSube.TabIndex = 1;
            // 
            // ucSinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSube);
            this.Controls.Add(this.lblSube);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Name = "ucSinif";
            this.Size = new System.Drawing.Size(408, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSube;
        private MetroFramework.Controls.MetroTextBox txtSube;
    }
}
