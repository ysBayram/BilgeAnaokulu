namespace BilgeAnaokulu
{
    partial class frmRaporlama
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.rptvMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(20, 60);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(547, 50);
            this.pnlTop.TabIndex = 1;
            // 
            // rptvMain
            // 
            this.rptvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvMain.Location = new System.Drawing.Point(20, 110);
            this.rptvMain.Name = "rptvMain";
            this.rptvMain.Size = new System.Drawing.Size(547, 269);
            this.rptvMain.TabIndex = 2;
            // 
            // frmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 399);
            this.Controls.Add(this.rptvMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmRaporlama";
            this.Text = "Raporlama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Microsoft.Reporting.WinForms.ReportViewer rptvMain;
    }
}