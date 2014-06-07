namespace Labels
{
    partial class PalletPF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.BarCode = new DevExpress.XtraReports.UI.XRBarCode();
        this.TexImage = new DevExpress.XtraReports.UI.XRPictureBox();
        this.Date = new DevExpress.XtraReports.UI.XRLabel();
        this.Shipment = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.PalletNumber = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
        this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
        ( ( System.ComponentModel.ISupportInitialize ) ( this ) ).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.BarCode,
            this.TexImage,
            this.Date,
            this.Shipment,
            this.xrLabel5,
            this.xrLabel4,
            this.PalletNumber,
            this.xrLabel1});
        this.Detail.HeightF = 393F;
        this.Detail.MultiColumn.ColumnSpacing = 10F;
        this.Detail.MultiColumn.ColumnWidth = 355F;
        this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BarCode
        // 
        this.BarCode.AutoModule = true;
        this.BarCode.LocationFloat = new DevExpress.Utils.PointFloat(100F, 233F);
        this.BarCode.Name = "BarCode";
        this.BarCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BarCode.SizeF = new System.Drawing.SizeF(175F, 67F);
        this.BarCode.Symbology = code128Generator1;
        this.BarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
        // 
        // TexImage
        // 
        this.TexImage.Borders = ( ( DevExpress.XtraPrinting.BorderSide ) ( ( ( ( DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top )
                    | DevExpress.XtraPrinting.BorderSide.Right )
                    | DevExpress.XtraPrinting.BorderSide.Bottom ) ) );
        this.TexImage.LocationFloat = new DevExpress.Utils.PointFloat(17F, 233F);
        this.TexImage.Name = "TexImage";
        this.TexImage.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TexImage.SizeF = new System.Drawing.SizeF(66F, 66F);
        this.TexImage.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        // 
        // Date
        // 
        this.Date.Font = new System.Drawing.Font("Times New Roman", 12F);
        this.Date.LocationFloat = new DevExpress.Utils.PointFloat(167F, 350F);
        this.Date.Name = "Date";
        this.Date.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.Date.SizeF = new System.Drawing.SizeF(100F, 25F);
        this.Date.Text = "xrLabel1";
        this.Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // Shipment
        // 
        this.Shipment.Font = new System.Drawing.Font("Times New Roman", 12F);
        this.Shipment.LocationFloat = new DevExpress.Utils.PointFloat(167F, 317F);
        this.Shipment.Name = "Shipment";
        this.Shipment.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.Shipment.SizeF = new System.Drawing.SizeF(100F, 25F);
        this.Shipment.Text = "xrLabel1";
        this.Shipment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel5
        // 
        this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F);
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(25F, 350F);
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 25F);
        this.xrLabel5.Text = "Дата";
        this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel4
        // 
        this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F);
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(25F, 317F);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 25F);
        this.xrLabel4.Text = "№ партiї ";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // PalletNumber
        // 
        this.PalletNumber.Font = new System.Drawing.Font("Times New Roman", 100F, System.Drawing.FontStyle.Bold);
        this.PalletNumber.LocationFloat = new DevExpress.Utils.PointFloat(17F, 50F);
        this.PalletNumber.Name = "PalletNumber";
        this.PalletNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.PalletNumber.SizeF = new System.Drawing.SizeF(258F, 167F);
        this.PalletNumber.Text = "333";
        this.PalletNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(50F, 17F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(183F, 25F);
        this.xrLabel1.Text = "№ пакувальної одиницi";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // topMarginBand1
        // 
        this.topMarginBand1.HeightF = 0F;
        this.topMarginBand1.Name = "topMarginBand1";
        // 
        // bottomMarginBand1
        // 
        this.bottomMarginBand1.HeightF = 0F;
        this.bottomMarginBand1.Name = "bottomMarginBand1";
        // 
        // PalletPF
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
        this.PageHeight = 398;
        this.PageWidth = 299;
        this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
        this.PaperName = "USER";
        this.PrinterName = "Intermec PF8t (203 dpi)";
        this.ShowPrintMarginsWarning = false;
        this.ShowPrintStatusDialog = false;
        this.Version = "10.2";
        ( ( System.ComponentModel.ISupportInitialize ) ( this ) ).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel Date;
        private DevExpress.XtraReports.UI.XRLabel Shipment;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel PalletNumber;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPictureBox TexImage;
        private DevExpress.XtraReports.UI.XRBarCode BarCode;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
    }
}
