using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Catalogs;
using Documents;

namespace Labels
{
    public partial class OneLabelPF : DevExpress.XtraReports.UI.XtraReport
    {        
        public OneLabelPF()
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

        public void Fill(Pallet pallet, double net, int bobbinNumber)
            {
            Tex.Text = pallet.Tex.Description;
            TexImage.Image = pallet.Tex.TexImage;
            if ( pallet.PrintLenght )
                {
                Length.Visible = true;
                Length.Text = ( pallet.PackType.Weight / Convert.ToInt32(pallet.Tex.Description) ).ToString();
                }
            else
                {
                Length.Visible = false;
                }

            Specification.Text = pallet.Specification.Number;
            if ( pallet.Complectation == Aramis.Enums.ComplectationType.Group )
                {
                Count.Visible = true;
                Count.Text = pallet.BobbinCount.ToString();
                }
            else
                {
                Count.Visible = false;
                }

            Net.Text = net.ToString();
            Shipment.Text = pallet.Shipment.ToString();
            BobbinNumber.Text = bobbinNumber.ToString();
            Date.Text = DateTime.Now.ToShortDateString();
            Senders sender = pallet.Sender;
            SenderDescription.Text = pallet.Sender.Name;
            SenderCity.Text = pallet.Sender.City;
            SenderAddress.Text = pallet.Sender.Street;
            SenderPhone1.Text = pallet.Sender.Phone1;
            SenderPhone2.Text = pallet.Sender.Phone2;
            SenderPhone3.Text = pallet.Sender.Phone3;
            BarCode.Text = String.Format("B.{0}.{1}", AddZero(pallet.Shipment.ToString(), 7), AddZero(bobbinNumber.ToString(), 4));
            }
    }
}
