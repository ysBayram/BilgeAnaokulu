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

namespace BilgeAnaokulu.UserController.SinavGoster
{
    public partial class ucSinavGoster : UserControl
    {
        public BAEntity.Sinav _Sinav { get; set; }
        public ucSinavGoster(BAEntity.Sinav sinav)
        {
            _Sinav = sinav;
            InitializeComponent();
            this.Load += ucSinavGoster_Load;
        }
        void ucSinavGoster_Load(object sender, EventArgs e)
        {
            if (_Sinav.BaslangicZaman<DateTime.Now && _Sinav.BitisZaman > DateTime.Now)
            {
                txtAd.Text = _Sinav.Ad;
                foreach (Soru sr in _Sinav.Sorular.OrderByDescending(x => x.No))
                {
                    ucSoruGoster ucsr = new ucSoruGoster(sr);
                    fpnlSorular.Controls.Add(ucsr);
                }
            }
            else
            {
                MessageBox.Show("Sınav Geçerlilik Süresi Geçmiştir!!!");
            }
        }

        private void tlBasla_Click(object sender, EventArgs e)
        {
            tmZaman.Enabled = true;
            fpnlSorular.Visible = true;
        }

        int saniye,dakika,saat = 0;
        private void tmZaman_Tick(object sender, EventArgs e)
        {
            if (dakika < _Sinav.Sure)
            {
                if (saniye < 59)
                {
                    saniye++;
                }
                else
                {
                    saniye = 0;
                    if (dakika < 59)
                    {
                        dakika++;
                    }
                    else
                    {
                        dakika = 0;
                        saat++;
                    }
                }
                tlBasla.Text = saat.ToString() + " " + dakika.ToString() + " " + saniye.ToString();
            }
            else
            {
                tlBasla.Text = "Sınav süreniz tamamlanmıştır!!!";
                fpnlSorular.Enabled = false;
            }
        }

    }
}
