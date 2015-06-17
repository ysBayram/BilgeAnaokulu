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
    public partial class ucSinav : UserControl, ICRUDuc
    {
        public ucSinav()
        {
            InitializeComponent();
        }

        public BAEntity.BAInput BACRUDInput { get; set; }

        Repository<Sinav> rpsi = new Repository<Sinav>();

        public void BACRUDInsert()
        {
            rpsi.Add(new Sinav()
            {
                Ad = txtAd.Text,
                Puan = Convert.ToInt16(txtPuan.Text),
                Sure = Convert.ToInt16(txtSure.Text),
                BaslangicZaman = dtpBaslangic.Value,
                BitisZaman = dtpBitis.Value,
                Egitmen = (Egitmen)cmbEgitmen.SelectedItem,
                Ders = (Ders)cmbDers.SelectedItem,
                Sinif = (Sinif)cmbSinif.SelectedItem
            });
        }

        public void BACRUDUpdate()
        {
            Sinav si = (Sinav)BACRUDInput;
            si.Ad = txtAd.Text;
            si.Puan = Convert.ToInt16(txtPuan.Text);
            si.Sure = Convert.ToInt16(txtSure.Text);
            si.BaslangicZaman = dtpBaslangic.Value;
            si.BitisZaman = dtpBitis.Value;
            si.Egitmen = (Egitmen)cmbEgitmen.SelectedItem;
            si.Ders = (Ders)cmbDers.SelectedItem;
            si.Sinif = (Sinif)cmbSinif.SelectedItem;

            rpsi.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpsi.Delete((Sinav)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpsi.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Sinav si = (Sinav)BACRUDInput;
            txtAd.Text = si.Ad;
            txtPuan.Text = si.Puan.ToString();
            txtSure.Text = si.Sure.ToString();
            dtpBaslangic.Value = si.BaslangicZaman;
            dtpBitis.Value = si.BitisZaman;
            cmbEgitmen.SelectedItem = si.Egitmen;
            cmbDers.SelectedItem = si.Ders;
            cmbSinif.SelectedItem = si.Sinif;
        }

        public void BACRUDClearComp()
        {
            BACRUDInput = null;
            txtAd.Text = string.Empty;
            txtPuan.Text = string.Empty;
            txtSure.Text = string.Empty;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            Repository<Egitmen> rpe = new Repository<Egitmen>();
            cmbEgitmen.DataSource = rpe.GetAll();
            cmbEgitmen.SelectedIndex = -1;
            Repository<Ders> rpd = new Repository<Ders>();
            cmbDers.DataSource = rpd.GetAll();
            cmbDers.SelectedIndex = -1;
            Repository<Sinif> rpsif = new Repository<Sinif>();
            cmbSinif.DataSource = rpsif.GetAll();
            cmbSinif.SelectedIndex = -1;
        }

        public bool BACRUDCheck()
        {
            bool ad = !string.IsNullOrEmpty(txtAd.Text);
            bool puan = !string.IsNullOrEmpty(txtPuan.Text);
            bool sure = !string.IsNullOrEmpty(txtSure.Text);
            bool egitmen = (cmbEgitmen.SelectedIndex != -1);
            bool ders = (cmbDers.SelectedIndex != -1);
            bool sinif = (cmbSinif.SelectedIndex != -1);

            return ad && puan && sure && egitmen && ders && sinif;
        }

        private void txtPuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
