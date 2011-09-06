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
            if (pallet.PrintLenght && pallet.PackType != null)
                {
                Length.Visible = true;
                xrLabel10.Visible = true;
                xrLabel2.Visible = true;
                Length.Text = ( pallet.PackType.Weight * 1000 / Convert.ToInt32(pallet.Tex.Description) ).ToString();
                }
            else
                {
                Length.Visible = false;
                xrLabel10.Visible = false;
                xrLabel2.Visible = false;
                }

            Specification.Text = pallet.Specification.Number;
            if ( pallet.Complectation == Aramis.Enums.ComplectationType.Group )
                {
                Count.Visible = true;
                Count.Text = pallet.BobbinCount.ToString();
                xrLabel3.Visible = true;
                }
            else
                {
                Count.Visible = false;
                xrLabel3.Visible = false;
                }

            Net.Text = pallet.PrintVirtualWeight ? net.ToString() + "±7%" : Math.Round(net, 1).ToString();
            Shipment.Text = pallet.Shipment.ToString();
            BobbinNumber.Text = bobbinNumber.ToString();
            Date.Text = DateTime.Now.ToShortDateString();
            Senders sender = pallet.Sender;
            SenderDescription.Text = pallet.Sender.Name;
            SenderCity.Text = pallet.Sender.City;
            SenderAddress.Text = String.Format("{0}, {1}", pallet.Sender.Street, pallet.Sender.HouseNum);
            SenderPhone1.Text = pallet.Sender.Phone1;
            SenderPhone2.Text = pallet.Sender.Phone2;
            SenderPhone3.Text = pallet.Sender.Phone3;
            BarCode.Text = String.Format("B.{0}.{1}", AddZero(pallet.Shipment.ToString(), 7), AddZero(bobbinNumber.ToString(), 4));
            }
    }
}
