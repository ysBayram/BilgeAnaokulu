namespace BilgeAnaokulu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yoklamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataislemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinavStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secenekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinavgosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataIslemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ogrenciToolStripMenuItem,
            this.egitmenToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.sinifToolStripMenuItem,
            this.yoklamaToolStripMenuItem,
            this.sinavToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 1;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataIslemToolStripMenuItem1,
            this.raporToolStripMenuItem});
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ogrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // egitmenToolStripMenuItem
            // 
            this.egitmenToolStripMenuItem.Name = "egitmenToolStripMenuItem";
            this.egitmenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.egitmenToolStripMenuItem.Text = "Eğitmen";
            this.egitmenToolStripMenuItem.Click += new System.EventHandler(this.egitmenToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            this.dersToolStripMenuItem.Click += new System.EventHandler(this.dersToolStripMenuItem_Click);
            // 
            // sinifToolStripMenuItem
            // 
            this.sinifToolStripMenuItem.Name = "sinifToolStripMenuItem";
            this.sinifToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sinifToolStripMenuItem.Text = "Sınıf";
            this.sinifToolStripMenuItem.Click += new System.EventHandler(this.sinifToolStripMenuItem_Click);
            // 
            // yoklamaToolStripMenuItem
            // 
            this.yoklamaToolStripMenuItem.Name = "yoklamaToolStripMenuItem";
            this.yoklamaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.yoklamaToolStripMenuItem.Text = "Yoklama";
            this.yoklamaToolStripMenuItem.Click += new System.EventHandler(this.yoklamaToolStripMenuItem_Click);
            // 
            // sinavToolStripMenuItem
            // 
            this.sinavToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataislemToolStripMenuItem,
            this.sinavgosterToolStripMenuItem});
            this.sinavToolStripMenuItem.Name = "sinavToolStripMenuItem";
            this.sinavToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.sinavToolStripMenuItem.Text = "Sınav";
            // 
            // dataislemToolStripMenuItem
            // 
            this.dataislemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinavStripMenuItem,
            this.soruToolStripMenuItem,
            this.secenekToolStripMenuItem});
            this.dataislemToolStripMenuItem.Name = "dataislemToolStripMenuItem";
            this.dataislemToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dataislemToolStripMenuItem.Text = "Data İşlemleri";
            // 
            // sinavStripMenuItem
            // 
            this.sinavStripMenuItem.Name = "sinavStripMenuItem";
            this.sinavStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sinavStripMenuItem.Text = "Sınav";
            this.sinavStripMenuItem.Click += new System.EventHandler(this.sinavStripMenuItem_Click);
            // 
            // soruToolStripMenuItem
            // 
            this.soruToolStripMenuItem.Name = "soruToolStripMenuItem";
            this.soruToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.soruToolStripMenuItem.Text = "Soru";
            this.soruToolStripMenuItem.Click += new System.EventHandler(this.soruToolStripMenuItem_Click);
            // 
            // secenekToolStripMenuItem
            // 
            this.secenekToolStripMenuItem.Name = "secenekToolStripMenuItem";
            this.secenekToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.secenekToolStripMenuItem.Text = "Seçenek";
            this.secenekToolStripMenuItem.Click += new System.EventHandler(this.secenekToolStripMenuItem_Click);
            // 
            // sinavgosterToolStripMenuItem
            // 
            this.sinavgosterToolStripMenuItem.Name = "sinavgosterToolStripMenuItem";
            this.sinavgosterToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sinavgosterToolStripMenuItem.Text = "Sınav Göster";
            this.sinavgosterToolStripMenuItem.Click += new System.EventHandler(this.sinavgosterToolStripMenuItem_Click);
            // 
            // dataIslemToolStripMenuItem1
            // 
            this.dataIslemToolStripMenuItem1.Name = "dataIslemToolStripMenuItem1";
            this.dataIslemToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dataIslemToolStripMenuItem1.Text = "Data İşlem";
            this.dataIslemToolStripMenuItem1.Click += new System.EventHandler(this.dataIslemToolStripMenuItem1_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "frmMain";
            this.Text = "Bilge Anaokulu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yoklamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataislemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinavStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secenekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinavgosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataIslemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
    }
}