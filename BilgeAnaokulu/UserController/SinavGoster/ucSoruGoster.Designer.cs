namespace BilgeAnaokulu.UserController.SinavGoster
{
    partial class ucSoruGoster
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
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.txtIcerik = new MetroFramework.Controls.MetroTextBox();
            this.fpnlSecenekler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Location = new System.Drawing.Point(4, 3);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(19, 13);
            this.lblSoruNo.TabIndex = 0;
            this.lblSoruNo.Text = "1 )";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIcerik.Location = new System.Drawing.Point(29, 0);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(321, 99);
            this.txtIcerik.TabIndex = 1;
            // 
            // fpnlSecenekler
            // 
            this.fpnlSecenekler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlSecenekler.Location = new System.Drawing.Point(3, 105);
            this.fpnlSecenekler.Name = "fpnlSecenekler";
            this.fpnlSecenekler.Size = new System.Drawing.Size(347, 200);
            this.fpnlSecenekler.TabIndex = 2;
            // 
            // ucSoruGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlSecenekler);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.lblSoruNo);
            this.Name = "ucSoruGoster";
            this.Size = new System.Drawing.Size(350, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoruNo;
        private MetroFramework.Controls.MetroTextBox txtIcerik;
        private System.Windows.Forms.FlowLayoutPanel fpnlSecenekler;
    }
}
