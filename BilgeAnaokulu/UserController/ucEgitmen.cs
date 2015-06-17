using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAProcess;
using BAEntity;

namespace BilgeAnaokulu.UserController
{
    public partial class ucEgitmen : UserControl,ICRUDuc
    {
        public ucEgitmen()
        {
            InitializeComponent();
        }

        public BAEntity.BAInput BACRUDInput { get; set; }

        Repository<Egitmen> rpe = new Repository<Egitmen>();

        public void BACRUDInsert()
        {
            rpe.Add(new Egitmen()
            {
                TCKimlikNo = txtTCKimlikNo.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Sifre = txtSifre.Text,
                Adres = txtAdres.Text,
                KanGrubu = (KanGrubulari)(Enum.Parse(typeof(KanGrubulari), cmbKanGrup.SelectedValue.ToString()))
            });
        }

        public void BACRUDUpdate()
        {
            Egitmen eg = (Egitmen)BACRUDInput;
            eg.TCKimlikNo = txtTCKimlikNo.Text;
            eg.Ad = txtAd.Text;
            eg.Soyad = txtSoyad.Text;
            eg.Sifre = txtSifre.Text;
            eg.Adres = txtAdres.Text;
            eg.KanGrubu = (KanGrubulari)(Enum.Parse(typeof(KanGrubulari), cmbKanGrup.SelectedValue.ToString()));

            rpe.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpe.Delete((Egitmen)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpe.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Egitmen eg = (Egitmen)BACRUDInput;
            txtTCKimlikNo.Text = eg.TCKimlikNo;
            txtAd.Text = eg.Ad;
            txtSoyad.Text = eg.Soyad;
            txtSifre.Text = eg.Sifre;
            txtAdres.Text = eg.Adres;
            cmbKanGrup.SelectedItem = eg.KanGrubu.ToString();
        }

        public void BACRUDClearComp()
        {
            BACRUDInput = null;
            txtTCKimlikNo.Text = string.Empty;
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtAdres.Text = string.Empty;
            cmbKanGrup.DataSource = Enum.GetNames(typeof(KanGrubulari));
            cmbKanGrup.SelectedIndex = -1;
        }

        public bool BACRUDCheck()
        {
            bool tcNo = !string.IsNullOrEmpty(txtTCKimlikNo.Text);
            bool ad = !string.IsNullOrEmpty(txtAd.Text);
            bool soyad = !string.IsNullOrEmpty(txtSoyad.Text);
            bool sifre = !string.IsNullOrEmpty(txtSifre.Text);
            bool adres = !string.IsNullOrEmpty(txtAdres.Text);
            bool kangrup = (cmbKanGrup.SelectedIndex != -1);

            return tcNo && ad && soyad && adres && kangrup && sifre;
        }

        private void txtTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
