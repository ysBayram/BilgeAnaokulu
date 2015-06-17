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
using BilgeAnaokulu.UserController;
using BAEntity;

namespace BilgeAnaokulu
{
    public partial class frmCRUD : MetroForm
    {
        public ICRUDuc uc { get; set; }

        public frmCRUD()
        {
            InitializeComponent();
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            UserControl DataUC = uc as UserControl;
            DataUC.Dock = DockStyle.Fill;
            pnlDetails.Controls.Add(DataUC);

            lstData.DataSource = uc.BACRUDGetAll();

            uc.BACRUDClearComp();
            btnUygula.Text = "Kaydet";
        }

        private void lstData_DoubleClick(object sender, EventArgs e)
        {
            uc.BACRUDInput = (BAInput)lstData.SelectedItem;
            uc.BACRUDLoadDetail();
            btnUygula.Text = "Düzenle";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            uc.BACRUDClearComp();
            btnUygula.Text = "Kaydet";
            MessageBox.Show("Alanlar Temizlendi!!!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (uc.BACRUDInput != null)
            {
                uc.BACRUDDelete();
                MessageBox.Show("Data Silindi!!!");

                lstData.DataSource = uc.BACRUDGetAll();
            }
            else
            {
                MessageBox.Show("Lütfen bir data Seçiniz!!!");
            }
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (uc.BACRUDInput == null)
            {
                if (uc.BACRUDCheck())
                {
                    uc.BACRUDInsert();
                    MessageBox.Show("Data Eklendi!!!");

                    lstData.DataSource = uc.BACRUDGetAll();
                    MessageBox.Show("Datalar Listelenmiştir!!!");
                }
                else
                {
                    MessageBox.Show("Gerekli Alanları Lütfen Doldurunuz!!!");
                }
            }
            else
            {
                uc.BACRUDUpdate();
                MessageBox.Show("Data Güncellenmiştir!!!");

                lstData.DataSource = uc.BACRUDGetAll();
                MessageBox.Show("Datalar Listelenmiştir!!!");
            }
        }

    }
}
