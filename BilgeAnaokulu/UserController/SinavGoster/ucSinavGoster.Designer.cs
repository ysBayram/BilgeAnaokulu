namespace BilgeAnaokulu.UserController.SinavGoster
{
    partial class ucSinavGoster
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
            this.components = new System.ComponentModel.Container();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.tlBasla = new MetroFramework.Controls.MetroTile();
            this.fpnlSorular = new System.Windows.Forms.FlowLayoutPanel();
            this.tmZaman = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(179, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(342, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlBasla
            // 
            this.tlBasla.Location = new System.Drawing.Point(600, 3);
            this.tlBasla.Name = "tlBasla";
            this.tlBasla.Size = new System.Drawing.Size(97, 58);
            this.tlBasla.TabIndex = 1;
            this.tlBasla.Text = "Başla";
            this.tlBasla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlBasla.Click += new System.EventHandler(this.tlBasla_Click);
            // 
            // fpnlSorular
            // 
            this.fpnlSorular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlSorular.Location = new System.Drawing.Point(0, 67);
            this.fpnlSorular.Name = "fpnlSorular";
            this.fpnlSorular.Size = new System.Drawing.Size(697, 299);
            this.fpnlSorular.TabIndex = 2;
            // 
            // tmZaman
            // 
            this.tmZaman.Interval = 1000;
            this.tmZaman.Tick += new System.EventHandler(this.tmZaman_Tick);
            // 
            // ucSinavGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlSorular);
            this.Controls.Add(this.tlBasla);
            this.Controls.Add(this.txtAd);
            this.Name = "ucSinavGoster";
            this.Size = new System.Drawing.Size(700, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroTile tlBasla;
        private System.Windows.Forms.FlowLayoutPanel fpnlSorular;
        private System.Windows.Forms.Timer tmZaman;
    }
}
