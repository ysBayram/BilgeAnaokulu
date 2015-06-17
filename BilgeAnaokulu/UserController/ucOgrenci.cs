using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAEntity;
using BAProcess;

namespace BilgeAnaokulu.UserController
{
    public partial class ucOgrenci : UserControl,ICRUDuc
    {
        public ucOgrenci()
        {
            InitializeComponent();
        }

        public BAInput BACRUDInput { get; set; }

        Repository<Ogrenci> rpo = new Repository<Ogrenci>();

        public void BACRUDInsert()
        {
            rpo.Add(new Ogrenci()
            {
                TCKimlikNo = txtTCKimlikNo.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Adres = txtAdres.Text,
                Sifre = txtSifre.Text,
                VeliAd = txtVeliAd.Text,
                VeliCepTel = txtCepTel.Text,
                VeliTel = txtTel.Text,
                KayitTarihi = dtpKayitTar.Value,
                KanGrubu = (KanGrubulari)(Enum.Parse(typeof(KanGrubulari), cmbKanGrup.SelectedValue.ToString())),
                Egitmeni = (Egitmen)(cmbEgitmen.SelectedItem),
                Sinifi = (Sinif)(cmbSinif.SelectedItem)
            });
        }

        public void BACRUDUpdate()
        {
            Ogrenci ogr = (Ogrenci)BACRUDInput;
            ogr.TCKimlikNo = txtTCKimlikNo.Text;
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.Sifre = txtSifre.Text;
            ogr.Adres = txtAdres.Text;
            ogr.VeliAd = txtVeliAd.Text;
            ogr.VeliCepTel = txtCepTel.Text;
            ogr.VeliTel = txtTel.Text;
            ogr.KayitTarihi = dtpKayitTar.Value;
            ogr.KanGrubu = (KanGrubulari)(Enum.Parse(typeof(KanGrubulari), cmbKanGrup.SelectedValue.ToString()));
            ogr.Egitmeni = (Egitmen)(cmbEgitmen.SelectedItem);
            ogr.Sinifi = (Sinif)(cmbSinif.SelectedItem);

            rpo.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpo.Delete((Ogrenci)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpo.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Ogrenci ogr = (Ogrenci)BACRUDInput;
            txtTCKimlikNo.Text = ogr.TCKimlikNo;
            txtAd.Text = ogr.Ad;
            txtSoyad.Text = ogr.Soyad;
            txtSifre.Text = ogr.Sifre;
            txtAdres.Text = ogr.Adres;
            txtVeliAd.Text = ogr.VeliAd;
            txtCepTel.Text = ogr.VeliCepTel;
            txtTel.Text = ogr.VeliTel;
            txtDonem.Text = ogr.Donem;
            dtpKayitTar.Value = ogr.KayitTarihi;
            cmbKanGrup.SelectedItem = ogr.KanGrubu.ToString();
            cmbEgitmen.SelectedItem = ogr.Egitmeni;
            cmbSinif.SelectedItem = ogr.Sinifi;
        }

        public void BACRUDClearComp()
        {
            BACRUDInput = null;
            txtTCKimlikNo.Text = string.Empty;
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtVeliAd.Text = string.Empty;
            txtCepTel.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtDonem.Text = string.Empty;
            dtpKayitTar.Value = DateTime.Now;
            cmbKanGrup.DataSource = Enum.GetNames(typeof(KanGrubulari));
            cmbKanGrup.SelectedIndex = -1;
            Repository<Egitmen> rpe = new Repository<Egitmen>();
            cmbEgitmen.DataSource = rpe.GetAll();
            cmbEgitmen.SelectedIndex = -1;
            Repository<Sinif> rps = new Repository<Sinif>();
            cmbSinif.DataSource = rps.GetAll();
            cmbSinif.SelectedIndex = -1;
        }

        public bool BACRUDCheck()
        {
            bool tcNo = !string.IsNullOrEmpty(txtTCKimlikNo.Text);
            bool ad = !string.IsNullOrEmpty(txtAd.Text);
            bool soyad = !string.IsNullOrEmpty(txtSoyad.Text);
            bool sifre = !string.IsNullOrEmpty(txtSifre.Text);
            bool adres = !string.IsNullOrEmpty(txtAdres.Text);
            bool kangrup = (cmbKanGrup.SelectedIndex != -1);
            bool veliad = !string.IsNullOrEmpty(txtVeliAd.Text);
            bool velicep = !string.IsNullOrEmpty(txtCepTel.Text);
            bool say = rpo.GetAll().Where(x => x.Donem == txtDonem.Text).ToList().Count <= 20;

            return tcNo && ad && soyad && adres && kangrup && veliad && velicep && say && sifre;
        }

        private void txtCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
