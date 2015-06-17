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
    public partial class ucYoklama : UserControl,ICRUDuc
    {
        public ucYoklama()
        {
            InitializeComponent();
        }

        public BAEntity.BAInput BACRUDInput { get; set; }

        Repository<Yoklama> rpy = new Repository<Yoklama>();

        public void BACRUDInsert()
        {
            rpy.Add(new Yoklama()
            {
                Tarih = dtpTarih.Value,
                DevamDurumu = tglDevamDurumu.Checked,
                Ogrenci = (Ogrenci)cmbOgrenci.SelectedItem
            });
        }

        public void BACRUDUpdate()
        {
            Yoklama yk = (Yoklama)BACRUDInput;
            yk.Tarih = dtpTarih.Value;
            yk.DevamDurumu = tglDevamDurumu.Checked;
            yk.Ogrenci = (Ogrenci)cmbOgrenci.SelectedItem;

            rpy.UpdateSaveChanges();
        }

        public void BACRUDDelete()
        {
            rpy.Delete((Yoklama)BACRUDInput);
        }

        public List<BAEntity.BAInput> BACRUDGetAll()
        {
            return rpy.GetAll().ToList<BAInput>();
        }

        public void BACRUDLoadDetail()
        {
            Yoklama yk = (Yoklama)BACRUDInput;
            dtpTarih.Value = yk.Tarih;
            tglDevamDurumu.Checked = yk.DevamDurumu;
            cmbOgrenci.SelectedItem = yk.Ogrenci;
        }

        public void BACRUDClearComp()
        {
            dtpTarih.Value = DateTime.Now;
            tglDevamDurumu.Checked = false;
            Repository<Ogrenci> rpo = new Repository<Ogrenci>();
            cmbOgrenci.DataSource = rpo.GetAll();
            cmbOgrenci.SelectedIndex = -1;
        }

        public bool BACRUDCheck()
        {
            bool ogrenci = (cmbOgrenci.SelectedIndex != -1);

            return ogrenci;
        }

        private void tglDevamDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (tglDevamDurumu.Checked)
            {
                tglDevamDurumu.Text = "Devamlı";
            }
            else
            {
                tglDevamDurumu.Text = "Devamsız";
            }
        }
    }
}
