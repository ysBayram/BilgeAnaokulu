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
using BilgeAnaokulu.UserController.SinavGoster;

namespace BilgeAnaokulu
{
    public partial class frmSinav : MetroForm
    {
        public frmSinav()
        {
            InitializeComponent();
            this.Load += frmSinav_Load;
        }

        void frmSinav_Load(object sender, EventArgs e)
        {
            Repository<Sinav> rpsi = new Repository<Sinav>();
            cmbSinav.DataSource = rpsi.GetAll();
        }

        private void cmbSinav_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSinav.Controls.Clear();
            ucSinavGoster ucsg = new ucSinavGoster((Sinav)cmbSinav.SelectedItem);
            pnlSinav.Controls.Add(ucsg);
        }
    }
}
