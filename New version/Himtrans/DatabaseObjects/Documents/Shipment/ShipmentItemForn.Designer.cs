namespace Documents.Forms
    {
    partial class ShipmentItemForn
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
            if ( disposing && ( components != null ) )
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
                this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
                this.OKButton = new DevExpress.XtraBars.BarButtonItem();
                this.WriteButton = new DevExpress.XtraBars.BarButtonItem();
                this.CancelButton = new DevExpress.XtraBars.BarButtonItem();
                this.ShowPalletButton = new DevExpress.XtraBars.BarButtonItem();
                this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
                this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
                this.TotalShipmentWeight = new DevExpress.XtraEditors.CalcEdit();
                this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
                this.Number = new DevExpress.XtraEditors.TextEdit();
                this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
                this.TexImage = new DevExpress.XtraEditors.PictureEdit();
                this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
                this.Tex = new DevExpress.XtraEditors.ButtonEdit();
                this.PalletsControl = new DevExpress.XtraGrid.GridControl();
                this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
                ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
                this.panelControl1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.TotalShipmentWeight.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.Number.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.TexImage.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.Tex.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.PalletsControl)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
                this.SuspendLayout();
                // 
                // ribbon
                // 
                this.ribbon.ApplicationButtonText = null;
                // 
                // 
                // 
                this.ribbon.ExpandCollapseItem.Id = 0;
                this.ribbon.ExpandCollapseItem.Name = "";
                this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.OKButton,
            this.WriteButton,
            this.CancelButton,
            this.ShowPalletButton});
                this.ribbon.Location = new System.Drawing.Point(0, 0);
                this.ribbon.MaxItemId = 5;
                this.ribbon.Name = "ribbon";
                this.ribbon.Size = new System.Drawing.Size(300, 53);
                this.ribbon.StatusBar = this.ribbonStatusBar;
                // 
                // OKButton
                // 
                this.OKButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
                this.OKButton.Caption = "OK";
                this.OKButton.Id = 1;
                this.OKButton.ImageIndex = 0;
                this.OKButton.Name = "OKButton";
                this.OKButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OK_ItemClick);
                // 
                // WriteButton
                // 
                this.WriteButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
                this.WriteButton.Caption = "Записать";
                this.WriteButton.Id = 2;
                this.WriteButton.Name = "WriteButton";
                this.WriteButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Write_ItemClick);
                // 
                // CancelButton
                // 
                this.CancelButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
                this.CancelButton.Caption = "Отмена";
                this.CancelButton.Id = 3;
                this.CancelButton.ImageIndex = 1;
                this.CancelButton.Name = "CancelButton";
                this.CancelButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
                // 
                // ShowPalletButton
                // 
                this.ShowPalletButton.Caption = "Открыть палету";
                this.ShowPalletButton.Id = 4;
                this.ShowPalletButton.Name = "ShowPalletButton";
                this.ShowPalletButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShowPalletButton_ItemClick);
                // 
                // ribbonStatusBar
                // 
                this.ribbonStatusBar.ItemLinks.Add(this.OKButton);
                this.ribbonStatusBar.ItemLinks.Add(this.WriteButton);
                this.ribbonStatusBar.ItemLinks.Add(this.CancelButton);
                this.ribbonStatusBar.ItemLinks.Add(this.ShowPalletButton);
                this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
                this.ribbonStatusBar.Name = "ribbonStatusBar";
                this.ribbonStatusBar.Ribbon = this.ribbon;
                this.ribbonStatusBar.Size = new System.Drawing.Size(300, 23);
                // 
                // panelControl1
                // 
                this.panelControl1.Controls.Add(this.TotalShipmentWeight);
                this.panelControl1.Controls.Add(this.labelControl3);
                this.panelControl1.Controls.Add(this.Number);
                this.panelControl1.Controls.Add(this.labelControl2);
                this.panelControl1.Controls.Add(this.TexImage);
                this.panelControl1.Controls.Add(this.labelControl1);
                this.panelControl1.Controls.Add(this.Tex);
                this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
                this.panelControl1.Location = new System.Drawing.Point(0, 53);
                this.panelControl1.Name = "panelControl1";
                this.panelControl1.Size = new System.Drawing.Size(300, 89);
                this.panelControl1.TabIndex = 2;
                // 
                // TotalShipmentWeight
                // 
                this.TotalShipmentWeight.Location = new System.Drawing.Point(99, 62);
                this.TotalShipmentWeight.MenuManager = this.ribbon;
                this.TotalShipmentWeight.Name = "TotalShipmentWeight";
                this.TotalShipmentWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                this.TotalShipmentWeight.Size = new System.Drawing.Size(134, 20);
                this.TotalShipmentWeight.TabIndex = 13;
                // 
                // labelControl3
                // 
                this.labelControl3.Location = new System.Drawing.Point(11, 65);
                this.labelControl3.Name = "labelControl3";
                this.labelControl3.Size = new System.Drawing.Size(56, 13);
                this.labelControl3.TabIndex = 12;
                this.labelControl3.Text = "Вес партии";
                // 
                // Number
                // 
                this.Number.Location = new System.Drawing.Point(99, 6);
                this.Number.MenuManager = this.ribbon;
                this.Number.Name = "Number";
                this.Number.Size = new System.Drawing.Size(134, 20);
                this.Number.TabIndex = 11;
                // 
                // labelControl2
                // 
                this.labelControl2.Location = new System.Drawing.Point(11, 9);
                this.labelControl2.Name = "labelControl2";
                this.labelControl2.Size = new System.Drawing.Size(70, 13);
                this.labelControl2.TabIndex = 10;
                this.labelControl2.Text = "Номер партии";
                // 
                // TexImage
                // 
                this.TexImage.Location = new System.Drawing.Point(239, 6);
                this.TexImage.MenuManager = this.ribbon;
                this.TexImage.Name = "TexImage";
                this.TexImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                this.TexImage.Size = new System.Drawing.Size(50, 50);
                this.TexImage.TabIndex = 9;
                // 
                // labelControl1
                // 
                this.labelControl1.Location = new System.Drawing.Point(11, 39);
                this.labelControl1.Name = "labelControl1";
                this.labelControl1.Size = new System.Drawing.Size(23, 13);
                this.labelControl1.TabIndex = 8;
                this.labelControl1.Text = "Текс";
                // 
                // Tex
                // 
                this.Tex.Location = new System.Drawing.Point(99, 36);
                this.Tex.MenuManager = this.ribbon;
                this.Tex.Name = "Tex";
                this.Tex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
                this.Tex.Size = new System.Drawing.Size(134, 20);
                this.Tex.TabIndex = 7;
                // 
                // PalletsControl
                // 
                this.PalletsControl.Dock = System.Windows.Forms.DockStyle.Fill;
                this.PalletsControl.Location = new System.Drawing.Point(0, 142);
                this.PalletsControl.MainView = this.gridView1;
                this.PalletsControl.MenuManager = this.ribbon;
                this.PalletsControl.Name = "PalletsControl";
                this.PalletsControl.Size = new System.Drawing.Size(300, 284);
                this.PalletsControl.TabIndex = 3;
                this.PalletsControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
                // 
                // gridView1
                // 
                this.gridView1.GridControl = this.PalletsControl;
                this.gridView1.Name = "gridView1";
                this.gridView1.OptionsView.ShowGroupPanel = false;
                this.gridView1.OptionsView.ShowIndicator = false;
                this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
                // 
                // ShipmentItemForn
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 449);
                this.Controls.Add(this.PalletsControl);
                this.Controls.Add(this.panelControl1);
                this.Controls.Add(this.ribbonStatusBar);
                this.Controls.Add(this.ribbon);
                this.Name = "ShipmentItemForn";
                this.Ribbon = this.ribbon;
                this.StatusBar = this.ribbonStatusBar;
                this.Text = "ShipmentItemForn";
                ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
                this.panelControl1.ResumeLayout(false);
                this.panelControl1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.TotalShipmentWeight.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.Number.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.TexImage.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.Tex.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.PalletsControl)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
                this.ResumeLayout(false);

            }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem OKButton;
        private DevExpress.XtraBars.BarButtonItem WriteButton;
        private DevExpress.XtraBars.BarButtonItem CancelButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit Number;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit TexImage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit Tex;
        private DevExpress.XtraGrid.GridControl PalletsControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CalcEdit TotalShipmentWeight;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem ShowPalletButton;
        }
    }