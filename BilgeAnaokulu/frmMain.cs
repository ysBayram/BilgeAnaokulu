using BilgeAnaokulu.UserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BAEntity;

namespace BilgeAnaokulu
{
    public partial class frmMain : Form
    {
        public GirisTur _girisTur { get; set; }
        public frmMain()
        {
            InitializeComponent();
            this.FormClosed += frmMain_FormClosed;
            this.Load += frmMain_Load;
        }

        void frmMain_Load(object sender, EventArgs e)
        {
            if (_girisTur == GirisTur.Ogrenci)
            {
                ogrenciToolStripMenuItem.Visible = false;
                dersToolStripMenuItem.Visible = false;
                egitmenToolStripMenuItem.Visible = false;
                sinifToolStripMenuItem.Visible = false;
                dataislemToolStripMenuItem.Visible = false;
            }
        }

        void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Menu Click Event


        private void egitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucEgitmen();
            _frmCRUD.Text = "Eğitmen İşlemleri";
            _frmCRUD.Show();
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucDers();
            _frmCRUD.Text = "Ders İşlemleri";
            _frmCRUD.Show();
        }

        private void sinifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucSinif();
            _frmCRUD.Text = "Sınıf İşlemleri";
            _frmCRUD.Show();
        }

        private void yoklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucYoklama();
            _frmCRUD.Text = "Yoklama İşlemleri";
            _frmCRUD.Show();
        }

        private void sinavStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucSinav();
            _frmCRUD.Text = "Sınav İşlemleri";
            _frmCRUD.Show();
        }

        private void soruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucSoru();
            _frmCRUD.Text = "Soru İşlemleri";
            _frmCRUD.Show();
        }

        private void secenekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucSecenek();
            _frmCRUD.Text = "Seçenek İşlemleri";
            _frmCRUD.Show();
        }
        #endregion

        private void sinavgosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinav _frmSinav = new frmSinav();
            //_frmSinav.MdiParent = this;
            _frmSinav.ShowDialog();
        }

        private void dataIslemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCRUD _frmCRUD = new frmCRUD();
            _frmCRUD.MdiParent = this;
            _frmCRUD.uc = new ucOgrenci();
            _frmCRUD.Text = "Öğrenci İşlemleri";
            _frmCRUD.Show();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporlama _frmRapor = new frmRaporlama();
            _frmRapor.MdiParent = this;
            _frmRapor.Show();
        }
    }
}
