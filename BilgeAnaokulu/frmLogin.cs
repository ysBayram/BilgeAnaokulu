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
using BAProcess;

namespace BilgeAnaokulu
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += frmLogin_Load;
        }

        void frmLogin_Load(object sender, EventArgs e)
        {
            cmbGirisTur.DataSource = Enum.GetNames(typeof(GirisTur));
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //if (cmbGirisTur.SelectedIndex != -1)
            //{
            //    if (cmbGirisTur.SelectedItem == GirisTur.Ogrenci.ToString())
            //    {
            //        Repository<Ogrenci> rpo = new Repository<Ogrenci>();
            //        Ogrenci og = rpo.ListByWhere(x => (x.TCKimlikNo == txtTCKimlik.Text) && (x.Sifre == txtSifre.Text)).FirstOrDefault();
            //        if (og != null)
            //        {
            //            frmMain frmMain = new frmMain();
            //            frmMain._girisTur = GirisTur.Ogrenci;
            //            frmMain.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Öğrenci Giriş Bilgileri Hatalı!!!");
            //        }
            //    }

            //    if (cmbGirisTur.SelectedItem == GirisTur.Egitmen.ToString())
            //    {
            //        Repository<Egitmen> rpe = new Repository<Egitmen>();
            //        Egitmen eg = rpe.ListByWhere(x => (x.TCKimlikNo == txtTCKimlik.Text) && (x.Sifre == txtSifre.Text)).FirstOrDefault();
            //        if (eg != null)
            //        {
            frmMain frmMain = new frmMain();
            frmMain._girisTur = GirisTur.Egitmen;
            frmMain.Show();
            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Eğitmen Giriş Bilgileri Hatalı!!!");
            //        }
            //    }
            //}
        }
    }
}
