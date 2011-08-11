namespace Documents.Forms
    {
    partial class PalletItemForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalletItemForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ShipingRePrintingButton = new DevExpress.XtraBars.BarButtonItem();
            this.PackingRenewalButton = new DevExpress.XtraBars.BarButtonItem();
            this.PackingEndButton = new DevExpress.XtraBars.BarButtonItem();
            this.PackingBreakButton = new DevExpress.XtraBars.BarButtonItem();
            this.RePrintingButton = new DevExpress.XtraBars.BarButtonItem();
            this.ManualEnteringButton = new DevExpress.XtraBars.BarButtonItem();
            this.BobbinRemovingButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TotalShipmentWeight = new DevExpress.XtraEditors.CalcEdit();
            this.TotalPalletWeight = new DevExpress.XtraEditors.CalcEdit();
            this.CurrentWeight = new DevExpress.XtraEditors.CalcEdit();
            this.PackType = new DevExpress.XtraEditors.ButtonEdit();
            this.EnterWeightButton = new DevExpress.XtraEditors.SimpleButton();
            this.StartButton = new DevExpress.XtraEditors.SimpleButton();
            this.CurrentShift = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BobbinCount = new DevExpress.XtraEditors.CalcEdit();
            this.PalletNumber = new DevExpress.XtraEditors.CalcEdit();
            this.Shipment = new DevExpress.XtraEditors.CalcEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBCurrentBabin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintLenght = new DevExpress.XtraEditors.CheckEdit();
            this.PrintLabel = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Counter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TexImage = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Tex = new DevExpress.XtraEditors.ButtonEdit();
            this.BobbinsControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ChangeFontTimer = new System.Windows.Forms.Timer(this.components);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.ribbon ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.applicationMenu1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.panelControl1 ) ).BeginInit();
            this.panelControl1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.TotalShipmentWeight.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.TotalPalletWeight.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.CurrentWeight.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PackType.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.CurrentShift.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.BobbinCount.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PalletNumber.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Shipment.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PrintLenght.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PrintLabel.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Counter.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.TexImage.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Tex.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.BobbinsControl ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridView1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.PackingRenewalButton,
            this.PackingEndButton,
            this.PackingBreakButton,
            this.RePrintingButton,
            this.ManualEnteringButton,
            this.BobbinRemovingButton,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barMdiChildrenListItem1,
            this.barMdiChildrenListItem2,
            this.ShipingRePrintingButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(901, 53);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.ShipingRePrintingButton);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // ShipingRePrintingButton
            // 
            this.ShipingRePrintingButton.Caption = "Печать спецификации";
            this.ShipingRePrintingButton.Enabled = false;
            this.ShipingRePrintingButton.Glyph = ( ( System.Drawing.Image ) ( resources.GetObject("ShipingRePrintingButton.Glyph") ) );
            this.ShipingRePrintingButton.Id = 17;
            this.ShipingRePrintingButton.Name = "ShipingRePrintingButton";
            this.ShipingRePrintingButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShipingRePrinting_ItemClick);
            // 
            // PackingRenewalButton
            // 
            this.PackingRenewalButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.PackingRenewalButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.PackingRenewalButton.Caption = "Доукомплектация";
            this.PackingRenewalButton.Id = 1;
            this.PackingRenewalButton.Name = "PackingRenewalButton";
            this.PackingRenewalButton.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.PackingRenewalButton_DownChanged);
            // 
            // PackingEndButton
            // 
            this.PackingEndButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.PackingEndButton.Caption = "Завершить";
            this.PackingEndButton.Id = 2;
            this.PackingEndButton.ImageIndex = 0;
            this.PackingEndButton.Name = "PackingEndButton";
            this.PackingEndButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PackingEndButton_ItemClick);
            // 
            // PackingBreakButton
            // 
            this.PackingBreakButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.PackingBreakButton.Caption = "Прервать";
            this.PackingBreakButton.Id = 3;
            this.PackingBreakButton.ImageIndex = 1;
            this.PackingBreakButton.Name = "PackingBreakButton";
            this.PackingBreakButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PackingBreakButton_ItemClick);
            // 
            // RePrintingButton
            // 
            this.RePrintingButton.Caption = "Повторная печать";
            this.RePrintingButton.Id = 4;
            this.RePrintingButton.ImageIndex = 21;
            this.RePrintingButton.Name = "RePrintingButton";
            this.RePrintingButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RePrintingButton_ItemClick);
            // 
            // ManualEnteringButton
            // 
            this.ManualEnteringButton.Caption = "Ручной ввод";
            this.ManualEnteringButton.Id = 5;
            this.ManualEnteringButton.Name = "ManualEnteringButton";
            this.ManualEnteringButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ManualEnteringButton_ItemClick);
            // 
            // BobbinRemovingButton
            // 
            this.BobbinRemovingButton.Caption = "Удалить бобину";
            this.BobbinRemovingButton.Id = 6;
            this.BobbinRemovingButton.ImageIndex = 4;
            this.BobbinRemovingButton.Name = "BobbinRemovingButton";
            this.BobbinRemovingButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BobbinRemovingButton_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 13;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Caption = "barMdiChildrenListItem2";
            this.barMdiChildrenListItem2.Id = 14;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.PackingRenewalButton);
            this.ribbonStatusBar.ItemLinks.Add(this.PackingEndButton);
            this.ribbonStatusBar.ItemLinks.Add(this.PackingBreakButton);
            this.ribbonStatusBar.ItemLinks.Add(this.RePrintingButton);
            this.ribbonStatusBar.ItemLinks.Add(this.ManualEnteringButton);
            this.ribbonStatusBar.ItemLinks.Add(this.BobbinRemovingButton);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(901, 23);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.TotalShipmentWeight);
            this.panelControl1.Controls.Add(this.TotalPalletWeight);
            this.panelControl1.Controls.Add(this.CurrentWeight);
            this.panelControl1.Controls.Add(this.PackType);
            this.panelControl1.Controls.Add(this.EnterWeightButton);
            this.panelControl1.Controls.Add(this.StartButton);
            this.panelControl1.Controls.Add(this.CurrentShift);
            this.panelControl1.Controls.Add(this.BobbinCount);
            this.panelControl1.Controls.Add(this.PalletNumber);
            this.panelControl1.Controls.Add(this.Shipment);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.LBCurrentBabin);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.PrintLenght);
            this.panelControl1.Controls.Add(this.PrintLabel);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Counter);
            this.panelControl1.Controls.Add(this.TexImage);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.Tex);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 53);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(901, 112);
            this.panelControl1.TabIndex = 2;
            // 
            // TotalShipmentWeight
            // 
            this.TotalShipmentWeight.Location = new System.Drawing.Point(684, 60);
            this.TotalShipmentWeight.MenuManager = this.ribbon;
            this.TotalShipmentWeight.Name = "TotalShipmentWeight";
            this.TotalShipmentWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TotalShipmentWeight.Size = new System.Drawing.Size(64, 20);
            this.TotalShipmentWeight.TabIndex = 80;
            this.TotalShipmentWeight.TabStop = false;
            // 
            // TotalPalletWeight
            // 
            this.TotalPalletWeight.Location = new System.Drawing.Point(684, 34);
            this.TotalPalletWeight.MenuManager = this.ribbon;
            this.TotalPalletWeight.Name = "TotalPalletWeight";
            this.TotalPalletWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TotalPalletWeight.Size = new System.Drawing.Size(64, 20);
            this.TotalPalletWeight.TabIndex = 79;
            this.TotalPalletWeight.TabStop = false;
            // 
            // CurrentWeight
            // 
            this.CurrentWeight.Location = new System.Drawing.Point(684, 6);
            this.CurrentWeight.MenuManager = this.ribbon;
            this.CurrentWeight.Name = "CurrentWeight";
            this.CurrentWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrentWeight.Size = new System.Drawing.Size(64, 20);
            this.CurrentWeight.TabIndex = 78;
            // 
            // PackType
            // 
            this.PackType.Location = new System.Drawing.Point(126, 88);
            this.PackType.MenuManager = this.ribbon;
            this.PackType.Name = "PackType";
            this.PackType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.PackType.Size = new System.Drawing.Size(88, 20);
            this.PackType.TabIndex = 77;
            // 
            // EnterWeightButton
            // 
            this.EnterWeightButton.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.EnterWeightButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.EnterWeightButton.Appearance.Options.UseFont = true;
            this.EnterWeightButton.Location = new System.Drawing.Point(773, 56);
            this.EnterWeightButton.Name = "EnterWeightButton";
            this.EnterWeightButton.Size = new System.Drawing.Size(116, 45);
            this.EnterWeightButton.TabIndex = 76;
            this.EnterWeightButton.Text = "Ввести";
            this.EnterWeightButton.Visible = false;
            this.EnterWeightButton.Click += new System.EventHandler(this.EnterWeightButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.StartButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.StartButton.Appearance.Options.UseFont = true;
            this.StartButton.Location = new System.Drawing.Point(773, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 45);
            this.StartButton.TabIndex = 75;
            this.StartButton.Text = "Начать";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CurrentShift
            // 
            this.CurrentShift.Location = new System.Drawing.Point(522, 5);
            this.CurrentShift.MenuManager = this.ribbon;
            this.CurrentShift.Name = "CurrentShift";
            this.CurrentShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrentShift.Size = new System.Drawing.Size(75, 20);
            this.CurrentShift.TabIndex = 3;
            // 
            // BobbinCount
            // 
            this.BobbinCount.Location = new System.Drawing.Point(331, 60);
            this.BobbinCount.MenuManager = this.ribbon;
            this.BobbinCount.Name = "BobbinCount";
            this.BobbinCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BobbinCount.Size = new System.Drawing.Size(94, 20);
            this.BobbinCount.TabIndex = 73;
            this.BobbinCount.Visible = false;
            // 
            // PalletNumber
            // 
            this.PalletNumber.Location = new System.Drawing.Point(331, 33);
            this.PalletNumber.MenuManager = this.ribbon;
            this.PalletNumber.Name = "PalletNumber";
            this.PalletNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PalletNumber.Size = new System.Drawing.Size(94, 20);
            this.PalletNumber.TabIndex = 2;
            // 
            // Shipment
            // 
            this.Shipment.Location = new System.Drawing.Point(331, 5);
            this.Shipment.MenuManager = this.ribbon;
            this.Shipment.Name = "Shipment";
            this.Shipment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Shipment.Size = new System.Drawing.Size(94, 20);
            this.Shipment.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Вес партии";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Вес поддона";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Количество бобин";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Смена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Номер поддона";
            // 
            // LBCurrentBabin
            // 
            this.LBCurrentBabin.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.LBCurrentBabin.ForeColor = System.Drawing.Color.Black;
            this.LBCurrentBabin.Location = new System.Drawing.Point(505, 36);
            this.LBCurrentBabin.Name = "LBCurrentBabin";
            this.LBCurrentBabin.Size = new System.Drawing.Size(92, 67);
            this.LBCurrentBabin.TabIndex = 63;
            this.LBCurrentBabin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(431, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "№ бобины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Вес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "№ партии";
            // 
            // PrintLenght
            // 
            this.PrintLenght.EditValue = true;
            this.PrintLenght.Location = new System.Drawing.Point(10, 88);
            this.PrintLenght.MenuManager = this.ribbon;
            this.PrintLenght.Name = "PrintLenght";
            this.PrintLenght.Properties.Caption = "Печать метража";
            this.PrintLenght.Size = new System.Drawing.Size(110, 19);
            this.PrintLenght.TabIndex = 6;
            // 
            // PrintLabel
            // 
            this.PrintLabel.EditValue = true;
            this.PrintLabel.Location = new System.Drawing.Point(10, 61);
            this.PrintLabel.MenuManager = this.ribbon;
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Properties.Caption = "Печать этикетки";
            this.PrintLabel.Size = new System.Drawing.Size(132, 19);
            this.PrintLabel.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Счетчик";
            // 
            // Counter
            // 
            this.Counter.EditValue = "";
            this.Counter.Location = new System.Drawing.Point(71, 33);
            this.Counter.MenuManager = this.ribbon;
            this.Counter.Name = "Counter";
            this.Counter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Counter.Size = new System.Drawing.Size(77, 20);
            this.Counter.TabIndex = 3;
            // 
            // TexImage
            // 
            this.TexImage.Location = new System.Drawing.Point(164, 5);
            this.TexImage.MenuManager = this.ribbon;
            this.TexImage.Name = "TexImage";
            this.TexImage.Properties.ShowMenu = false;
            this.TexImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.TexImage.Size = new System.Drawing.Size(50, 48);
            this.TexImage.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Текс";
            // 
            // Tex
            // 
            this.Tex.Location = new System.Drawing.Point(71, 5);
            this.Tex.MenuManager = this.ribbon;
            this.Tex.Name = "Tex";
            this.Tex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Tex.Size = new System.Drawing.Size(77, 20);
            this.Tex.TabIndex = 0;
            // 
            // BobbinsControl
            // 
            this.BobbinsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BobbinsControl.Location = new System.Drawing.Point(0, 165);
            this.BobbinsControl.MainView = this.gridView1;
            this.BobbinsControl.MenuManager = this.ribbon;
            this.BobbinsControl.Name = "BobbinsControl";
            this.BobbinsControl.Size = new System.Drawing.Size(901, 261);
            this.BobbinsControl.TabIndex = 3;
            this.BobbinsControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.BobbinsControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BobbinsControl_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.BobbinsControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // ChangeFontTimer
            // 
            this.ChangeFontTimer.Interval = 2500;
            this.ChangeFontTimer.Tick += new System.EventHandler(this.ChangeFontTimer_Tick);
            // 
            // PalletItemForm
            // 
            this.AcceptButton = this.EnterWeightButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 449);
            this.Controls.Add(this.BobbinsControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(864, 450);
            this.Name = "PalletItemForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PalletItemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PalletItemForm_FormClosing);
            this.Load += new System.EventHandler(this.PalletItemForm_Load);
            this.Shown += new System.EventHandler(this.PalletItemForm_Shown);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.ribbon ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.applicationMenu1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.panelControl1 ) ).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.TotalShipmentWeight.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.TotalPalletWeight.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.CurrentWeight.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PackType.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.CurrentShift.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.BobbinCount.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PalletNumber.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Shipment.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PrintLenght.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PrintLabel.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Counter.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.TexImage.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Tex.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.BobbinsControl ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridView1 ) ).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl BobbinsControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit TexImage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit Tex;
        private DevExpress.XtraEditors.CheckEdit PrintLenght;
        private DevExpress.XtraEditors.CheckEdit PrintLabel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit Counter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBCurrentBabin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CalcEdit Shipment;
        private DevExpress.XtraEditors.CalcEdit BobbinCount;
        private DevExpress.XtraEditors.CalcEdit PalletNumber;
        private DevExpress.XtraEditors.ComboBoxEdit CurrentShift;
        private DevExpress.XtraBars.BarButtonItem PackingRenewalButton;
        private DevExpress.XtraBars.BarButtonItem PackingEndButton;
        private DevExpress.XtraBars.BarButtonItem PackingBreakButton;
        private DevExpress.XtraEditors.SimpleButton EnterWeightButton;
        private DevExpress.XtraEditors.SimpleButton StartButton;
        private DevExpress.XtraBars.BarButtonItem RePrintingButton;
        private DevExpress.XtraBars.BarButtonItem ManualEnteringButton;
        private DevExpress.XtraBars.BarButtonItem BobbinRemovingButton;
        private DevExpress.XtraEditors.ButtonEdit PackType;
        private DevExpress.XtraEditors.CalcEdit CurrentWeight;
        private DevExpress.XtraEditors.CalcEdit TotalShipmentWeight;
        private DevExpress.XtraEditors.CalcEdit TotalPalletWeight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private System.Windows.Forms.Timer ChangeFontTimer;
        private DevExpress.XtraBars.BarButtonItem ShipingRePrintingButton;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        }
    }