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
    public partial class ucSoruGoster : UserControl
    {
        public Soru _Soru { get; set; }

        public ucSoruGoster(Soru soru )
        {
            _Soru = soru;
            InitializeComponent();
            this.Load += ucSoruGoster_Load;
        }

        void ucSoruGoster_Load(object sender, EventArgs e)
        {
            lblSoruNo.Text = _Soru.No.ToString();
            txtIcerik.Text = _Soru.Icerik;

            foreach (Secenek sc in _Soru.Secenekler.OrderByDescending(x=> x.Baslik))
            {
                ucSecenekGoster ucsc = new ucSecenekGoster(sc);
                fpnlSecenekler.Controls.Add(ucsc);
            }

        }
    }
}
