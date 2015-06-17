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
    public partial class ucSecenek : UserControl,ICRUDuc
    {
        public ucSecenek()
        {
            InitializeComponent();
        }

        public BAEntity.BAInput BACRUDInput { get; set; }

        Repository<Secenek> rps = new Repository<Secenek>();

        public void BACRUDInsert()
        {
            Secenek sc = new Secenek();
            sc.Baslik = txtBaslik.Text;
            sc.IcerikTur = (SecenekTur)(pnlIcerikTur.Controls.OfType<RadioButton>().FirstOrDefault(x=> x.Checked).Tag);
            sc.Icerik = txtIcerik.Text;
            sc.Soru = (Soru)cmbSoru.SelectedItem;

            rps.Add(sc);
        }

        public void BACRUDUpdate()
        {
            Secenek sc = (Secenek)BACRUDInput;
            sc.Baslik = txtBaslik.Text;
            sc.IcerikTur = (SecenekTur)(pnlIcerikTur.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag);
            sc.Icerik = txtIcerik.Text;
            sc.Soru = (Soru)cmbSoru.SelectedItem;

            rps.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rps.Delete((Secenek)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rps.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Secenek sc = (Secenek)BACRUDInput;
            txtBaslik.Text = sc.Baslik;
            pnlIcerikTur.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag = sc.IcerikTur;
            txtIcerik.Text = sc.Icerik;
            cmbSoru.SelectedItem = sc.Soru;
        }

        public void BACRUDClearComp()
        {
            BACRUDInput = null;
            txtBaslik.Text = string.Empty;
            rbtnMetin.Checked = true;
            txtIcerik.Text = string.Empty;
            Repository<Soru> rpso = new Repository<Soru>();
            cmbSoru.DataSource = rpso.GetAll();
            cmbSoru.SelectedIndex = -1;
        }

        public bool BACRUDCheck()
        {
            bool baslik = !string.IsNullOrEmpty(txtBaslik.Text);
            bool iceriktur = (pnlIcerikTur.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked) != null);
            bool icerik = !string.IsNullOrEmpty(txtIcerik.Text);
            bool soru = (cmbSoru.SelectedIndex != -1);

            return baslik && iceriktur && icerik && soru;
        }

        private void rbtnMetin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetin.Checked)
            {
                txtIcerik.ReadOnly = false;
            }      
        }

        private void rbtnResim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnResim.Checked)
            {
                txtIcerik.ReadOnly = true;

                if (opfIcerik.ShowDialog() == DialogResult.OK)
                {
                    opfIcerik.Filter = "Resim Dosyası |*.jpg;*.jpeg;*.png";
                    opfIcerik.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    txtIcerik.Text = opfIcerik.FileName;
                }
            }
        }
    }
}
