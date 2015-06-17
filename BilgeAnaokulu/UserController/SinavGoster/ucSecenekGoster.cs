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
    public partial class ucSecenekGoster : UserControl
    {
        private Secenek _Secenek { get; set; }

        public ucSecenekGoster(Secenek secenek)
        {
            _Secenek = secenek;
            InitializeComponent();
            this.Load += ucSecenekGoster_Load;
        }

        void ucSecenekGoster_Load(object sender, EventArgs e)
        {
            switch (_Secenek.IcerikTur)
            {
                case SecenekTur.Metin: pbIcerik.Visible = false; txtIcerik.Text = _Secenek.Icerik;
                    break;
                case SecenekTur.Resim: txtIcerik.Visible = false; pbIcerik.Image = Image.FromFile(_Secenek.Icerik);
                    break;
            }

            lblBaslik.Text = _Secenek.Baslik;

        }
    }
}
