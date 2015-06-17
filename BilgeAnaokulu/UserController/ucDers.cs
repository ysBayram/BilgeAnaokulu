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
    public partial class ucDers : UserControl, ICRUDuc
    {
        public ucDers()
        {
            InitializeComponent();
        }

        public BAInput BACRUDInput { get; set; }

        Repository<Ders> rpd = new Repository<Ders>();

        public void BACRUDInsert()
        {
            rpd.Add(new Ders()
            {
                Ad = txtAd.Text,
                Icerik = txtIcerik.Text,
                BaslamaZaman = dtpBaslama.Value,
                BitisZaman = dtpBitis.Value,
                Sinifi = (Sinif)cmbSinif.SelectedItem,
                Egitmeni = (Egitmen)cmbEgitmen.SelectedItem
            });
        }

        public void BACRUDUpdate()
        {
            Ders de = (Ders)BACRUDInput;
            de.Ad = txtAd.Text;
            de.Icerik = txtIcerik.Text;
            de.BaslamaZaman = dtpBaslama.Value;
            de.BitisZaman = dtpBitis.Value;
            de.Sinifi = (Sinif)cmbSinif.SelectedItem;
            de.Egitmeni = (Egitmen)cmbEgitmen.SelectedItem;

            rpd.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpd.Delete((Ders)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpd.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Ders de = (Ders)BACRUDInput;
            txtAd.Text = de.Ad;
            txtIcerik.Text = de.Icerik;
            dtpBaslama.Value = de.BaslamaZaman;
            dtpBitis.Value = de.BitisZaman;
            cmbSinif.SelectedItem = de.Sinifi;
            cmbEgitmen.SelectedItem = de.Egitmeni;
        }

        public void BACRUDClearComp()
        {
            BACRUDInput = null;
            txtAd.Text = string.Empty;
            txtIcerik.Text = string.Empty;
            dtpBaslama.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            Repository<Sinif> rps = new Repository<Sinif>();
            cmbSinif.DataSource = rps.GetAll();
            cmbSinif.SelectedIndex = -1;
            Repository<Egitmen> rpe = new Repository<Egitmen>();
            cmbEgitmen.DataSource = rpe.GetAll();
            cmbEgitmen.SelectedIndex = -1;
        }

        public bool BACRUDCheck()
        {
            bool ad = !string.IsNullOrEmpty(txtAd.Text);

            return ad;
        }
    }
}
