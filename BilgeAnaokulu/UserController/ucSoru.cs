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
    public partial class ucSoru : UserControl, ICRUDuc
    {
        public ucSoru()
        {
            InitializeComponent();
        }

        public BAEntity.BAInput BACRUDInput { get; set; }

        Repository<Soru> rpso = new Repository<Soru>();

        public void BACRUDInsert()
        {
            rpso.Add(new Soru()
            {
                Icerik = txtIcerik.Text,
                PuanDeger = Convert.ToInt16(txtPuan.Text),
                No = Convert.ToInt16(txtSoruNo.Text),
                Sinav = (Sinav)cmbSinav.SelectedItem,
                DogruSecenek = (Secenek)cmbDSec.SelectedItem
            });
        }

        public void BACRUDUpdate()
        {
            Soru so = (Soru)BACRUDInput;
            so.Icerik = txtIcerik.Text;
            so.PuanDeger = Convert.ToInt16(txtPuan.Text);
            so.No = Convert.ToInt16(txtSoruNo.Text);
            so.Sinav = (Sinav)cmbSinav.SelectedItem;
            so.DogruSecenek = (Secenek)cmbDSec.SelectedItem;

            rpso.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpso.Delete((Soru)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpso.GetAll().ToList<BAInput>();
        }

        Repository<Secenek> rpse = new Repository<Secenek>();

        public void BACRUDLoadDetail()
        {
            Soru so = (Soru)BACRUDInput;
            txtIcerik.Text = so.Icerik;
            txtPuan.Text = so.PuanDeger.ToString();
            txtSoruNo.Text = so.No.ToString();
            cmbSinav.SelectedItem = so.Sinav;
            cmbDSec.DataSource = rpse.GetAll().Where(x => x.Soru == so).ToList();
            cmbDSec.DisplayMember = "Baslik";
            cmbDSec.SelectedItem = so.DogruSecenek;
        }

        public void BACRUDClearComp()
        {
            txtIcerik.Text = string.Empty;
            txtPuan.Text = string.Empty;
            txtSoruNo.Text = string.Empty;
            Repository<Sinav> rpsi = new Repository<Sinav>();
            cmbSinav.DataSource = rpsi.GetAll();
            cmbSinav.SelectedIndex = -1;
            cmbDSec.DataSource = rpse.GetAll().Where(x=> x.Soru == (Soru)BACRUDInput).ToList();
            cmbDSec.DisplayMember = "Baslik";
            cmbDSec.SelectedIndex = -1;
            BACRUDInput = null;
        }

        public bool BACRUDCheck()
        {
            bool icerik = !string.IsNullOrEmpty(txtIcerik.Text);
            bool puan = !string.IsNullOrEmpty(txtPuan.Text);
            bool no = !string.IsNullOrEmpty(txtSoruNo.Text);
            bool sinav = (cmbSinav.SelectedIndex != -1);
            bool dsec = (cmbDSec.SelectedIndex != -1);

            return icerik && puan && sinav && dsec && no;
        }

        private void txtPuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoruNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
