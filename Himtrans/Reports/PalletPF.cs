using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Documents;

namespace Labels
{
    public partial class PalletPF : DevExpress.XtraReports.UI.XtraReport
    {
        public PalletPF()
        {
            InitializeComponent();
        }

        private string AddZero(string text, int length)
        {
            string tmp = text;
            while (tmp.Length < length)
                tmp = "0" + tmp;
            return tmp;
        }

        public void Fill(string palletnum, string partnum, Image img)
        {
            this.PalletNumber.Text = palletnum;
            this.Shipment.Text = partnum;
            this.Date.Text = DateTime.Now.ToString("dd.MM.yyyy");
            this.TexImage.Image = img;
            BarCode.Text = String.Format("P.{0}.{1}", AddZero(partnum, 7), AddZero(palletnum, 2));
        }

        public void Fill(Pallet pallet)
            {
            PalletNumber.Text = pallet.PalletNumber.ToString();
            TexImage.Image = pallet.Tex.TexImage;
            Shipment.Text = pallet.Shipment.ToString();
            Date.Text = DateTime.Now.ToShortDateString();
            BarCode.Text = String.Format("P.{0}.{1}", AddZero(pallet.Shipment.ToString(), 7), AddZero(pallet.PalletNumber.ToString(), 2));
            }
    }
}
