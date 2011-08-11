using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Documents;
using DevExpress.XtraReports.UI;

namespace Labels
{
    public partial class ShippingPF : DevExpress.XtraReports.UI.XtraReport
    {
        private double[] sum = new double[4];

        public ShippingPF()
        {
            InitializeComponent();
        }

        public void Fill(Pallet PL)
        {            
            int i = 0;
            int j = 0;
            for (int k = 0; k < 4; k++) sum[k] = 0;            
            while ((i < PL.Bobbins.Rows.Count)&&(i < 30))
                {
                    DataRow row = dataSet1.Tables[0].NewRow();
                    row[1] = Convert.ToDouble(PL.Bobbins.Rows[i]["Weight"].ToString());
                    row[0] = PL.Bobbins.Rows[i]["BobbinNumber"];
                    row[2] = PL.Bobbins.Rows[i]["Customer"];
                    dataSet1.Tables[0].Rows.Add(row);
                    sum[j] += Convert.ToDouble(row[1].ToString());
                    i++;
                    j = ((int)(i / 30));
                }
            while ( i < PL.Bobbins.Rows.Count )
            {
            dataSet1.Tables[0].Rows[i - j * 30][j * 3 + 1] = Convert.ToDouble(PL.Bobbins.Rows[i]["Weight"].ToString());
            dataSet1.Tables[0].Rows[i - j * 30][j * 3] = PL.Bobbins.Rows[i]["BobbinNumber"];
            dataSet1.Tables[0].Rows[i - j * 30][j * 3 + 2] = PL.Bobbins.Rows[i]["Customer"];
            sum[j] += Convert.ToDouble(PL.Bobbins.Rows[i]["Weight"].ToString());
                i++;
                j = ((int)(i / 30));
            }
            if (i > 30)
            {
                xrTable2.Visible = true;
                xrTable6.Visible = true;
                xrTable10.Visible = true;
            }
            if (i > 60)          
                {
                    xrTable3.Visible = true;
                    xrTable7.Visible = true;
                    xrTable11.Visible = true;
                }
            
            if (i > 90)
            {
                xrTable4.Visible = true;
                xrTable8.Visible = true;
                xrTable12.Visible = true;
            }
            Total1.Text = sum[0].ToString();
            Total2.Text = sum[1].ToString();
            Total3.Text = sum[2].ToString();
            Total4.Text = sum[3].ToString();
            LBSender.Text = PL.Sender.Name;
            LBDate.Text = PL.Date.ToString();
            LBPart.Text = PL.Shipment.ToString();
            LBShippingNum.Text = PL.PalletNumber.ToString();
            LBTeks.Text = PL.Tex.Description;
            LBTotalWeight.Text = Math.Round(PL.TotalPalletWeight,3).ToString();
            LBTotalPartWeight.Text = ((Shipment)PL.ShipmentDoc.Read()).TotalShipmentWeight.ToString();
        }

    }
}
