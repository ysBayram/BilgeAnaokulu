namespace BilgeAnaokulu.UserController
{
    partial class ucSecenek
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
            this.rbtnMetin = new System.Windows.Forms.RadioButton();
            this.rbtnResim = new System.Windows.Forms.RadioButton();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtBaslik = new MetroFramework.Controls.MetroTextBox();
            this.pnlIcerikTur = new System.Windows.Forms.Panel();
            this.txtIcerik = new MetroFramework.Controls.MetroTextBox();
            this.opfIcerik = new System.Windows.Forms.OpenFileDialog();
            this.lblSoru = new System.Windows.Forms.Label();
            this.cmbSoru = new MetroFramework.Controls.MetroComboBox();
            this.pnlIcerikTur.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnMetin
            // 
            this.rbtnMetin.AutoSize = true;
            this.rbtnMetin.Location = new System.Drawing.Point(3, 3);
            this.rbtnMetin.Name = "rbtnMetin";
            this.rbtnMetin.Size = new System.Drawing.Size(51, 17);
            this.rbtnMetin.TabIndex = 0;
            this.rbtnMetin.TabStop = true;
            this.rbtnMetin.Text = "Metin";
            this.rbtnMetin.UseVisualStyleBackColor = true;
            this.rbtnMetin.CheckedChanged += new System.EventHandler(this.rbtnMetin_CheckedChanged);
            // 
            // rbtnResim
            // 
            this.rbtnResim.AutoSize = true;
            this.rbtnResim.Location = new System.Drawing.Point(94, 3);
            this.rbtnResim.Name = "rbtnResim";
            this.rbtnResim.Size = new System.Drawing.Size(54, 17);
            this.rbtnResim.TabIndex = 1;
            this.rbtnResim.TabStop = true;
            this.rbtnResim.Text = "Resim";
            this.rbtnResim.UseVisualStyleBackColor = true;
            this.rbtnResim.CheckedChanged += new System.EventHandler(this.rbtnResim_CheckedChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(18, 62);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(35, 13);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Başlık";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(112, 58);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(175, 23);
            this.txtBaslik.TabIndex = 0;
            // 
            // pnlIcerikTur
            // 
            this.pnlIcerikTur.Controls.Add(this.rbtnMetin);
            this.pnlIcerikTur.Controls.Add(this.rbtnResim);
            this.pnlIcerikTur.Location = new System.Drawing.Point(18, 88);
            this.pnlIcerikTur.Name = "pnlIcerikTur";
            this.pnlIcerikTur.Size = new System.Drawing.Size(269, 23);
            this.pnlIcerikTur.TabIndex = 1;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(18, 117);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(269, 23);
            this.txtIcerik.TabIndex = 2;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(18, 24);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(29, 13);
            this.lblSoru.TabIndex = 3;
            this.lblSoru.Text = "Soru";
            // 
            // cmbSoru
            // 
            this.cmbSoru.FormattingEnabled = true;
            this.cmbSoru.ItemHeight = 23;
            this.cmbSoru.Location = new System.Drawing.Point(112, 16);
            this.cmbSoru.Name = "cmbSoru";
            this.cmbSoru.Size = new System.Drawing.Size(175, 29);
            this.cmbSoru.TabIndex = 4;
            // 
            // ucSecenek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSoru);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.pnlIcerikTur);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lblBaslik);
            this.Name = "ucSecenek";
            this.Size = new System.Drawing.Size(309, 154);
            this.pnlIcerikTur.ResumeLayout(false);
            this.pnlIcerikTur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMetin;
        private System.Windows.Forms.RadioButton rbtnResim;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlIcerikTur;
        private MetroFramework.Controls.MetroTextBox txtIcerik;
        private System.Windows.Forms.OpenFileDialog opfIcerik;
        private System.Windows.Forms.Label lblSoru;
        private MetroFramework.Controls.MetroComboBox cmbSoru;
        private MetroFramework.Controls.MetroTextBox txtBaslik;
    }
}
