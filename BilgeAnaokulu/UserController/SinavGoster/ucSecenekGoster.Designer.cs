namespace BilgeAnaokulu.UserController.SinavGoster
{
    partial class ucSecenekGoster
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtIcerik = new MetroFramework.Controls.MetroTextBox();
            this.pbIcerik = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcerik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(3, 3);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(20, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "A )";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtIcerik.Location = new System.Drawing.Point(29, 0);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.ReadOnly = true;
            this.txtIcerik.Size = new System.Drawing.Size(321, 102);
            this.txtIcerik.TabIndex = 1;
            // 
            // pbIcerik
            // 
            this.pbIcerik.Location = new System.Drawing.Point(29, 0);
            this.pbIcerik.Name = "pbIcerik";
            this.pbIcerik.Size = new System.Drawing.Size(116, 100);
            this.pbIcerik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcerik.TabIndex = 2;
            this.pbIcerik.TabStop = false;
            // 
            // ucSecenekGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbIcerik);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtIcerik);
            this.Name = "ucSecenekGoster";
            this.Size = new System.Drawing.Size(350, 102);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private MetroFramework.Controls.MetroTextBox txtIcerik;
        private System.Windows.Forms.PictureBox pbIcerik;
    }
}
