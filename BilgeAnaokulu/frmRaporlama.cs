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
    public partial class frmRaporlama : MetroForm
    {
        public frmRaporlama()
        {
            InitializeComponent();
            this.Load += frmRaporlama_Load;
        }

        void frmRaporlama_Load(object sender, EventArgs e)
        {
            Repository<Ogrenci> rpo = new Repository<Ogrenci>();

            rptvMain.LocalReport.DataSources.Clear();
            rptvMain.LocalReport.ReportEmbeddedResource = "BilgeAnaokulu.Raporlar.rpOgrenci.rdlc";

            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DSOgrenci", rpo.GetAll());
            rptvMain.LocalReport.DataSources.Add(dataset);
            dataset.Value = rpo.GetAll();

            rptvMain.LocalReport.Refresh();
            rptvMain.RefreshReport();
        }

    }
}
