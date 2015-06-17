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
    public partial class ucSinif : UserControl,ICRUDuc
    {
        public ucSinif()
        {
            InitializeComponent();
        }

        public BAEntity.BAInput BACRUDInput { get; set; }

        Repository<Sinif> rpsi = new Repository<Sinif>();

        public void BACRUDInsert()
        {
            rpsi.Add(new Sinif()
            {
                Ad = txtAd.Text,
                Sube = txtSube.Text
            });
        }

        public void BACRUDUpdate()
        {
            Sinif si = (Sinif)BACRUDInput;
            si.Ad = txtAd.Text;
            si.Sube = txtSube.Text;

            rpsi.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpsi.Delete((Sinif)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpsi.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Sinif si = (Sinif)BACRUDInput;
            txtAd.Text = si.Ad;
            txtSube.Text = si.Sube;
        }

        public void BACRUDClearComp()
        {
            BACRUDInput = null;
            txtAd.Text = string.Empty;
            txtSube.Text = string.Empty;
        }

        public bool BACRUDCheck()
        {
            bool ad = !string.IsNullOrEmpty(txtAd.Text);
            bool sube = !string.IsNullOrEmpty(txtSube.Text);

            return ad && sube;
        }
    }
}
