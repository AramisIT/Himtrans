namespace Catalogs.Forms
    {
    partial class ConstsForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.OKButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SpecificationsNumber = new DevExpress.XtraEditors.LabelControl();
            this.Specification = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Sender = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BreakedComplectation = new DevExpress.XtraEditors.ColorEdit();
            this.PostedComplectation = new DevExpress.XtraEditors.ColorEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.imageEdit1 = new DevExpress.XtraEditors.ImageEdit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.ribbon ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Specification.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Sender.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.BreakedComplectation.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PostedComplectation.Properties ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.groupControl3 ) ).BeginInit();
            this.groupControl3.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.imageEdit1.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.OKButton);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 281);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(302, 23);
            // 
            // OKButton
            // 
            this.OKButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.OKButton.Caption = "OK";
            this.OKButton.Id = 6;
            this.OKButton.ImageIndex = 0;
            this.OKButton.Name = "OKButton";
            this.OKButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OKButton_ItemClick);
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
            this.barButtonGroup1,
            this.OKButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(302, 53);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 4;
            this.barButtonGroup1.ItemLinks.Add(this.OKButton);
            this.barButtonGroup1.MenuAppearance.Menu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.barButtonGroup1.MenuAppearance.Menu.Options.UseFont = true;
            this.barButtonGroup1.MenuAppearance.MenuBar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.barButtonGroup1.MenuAppearance.MenuBar.Options.UseFont = true;
            this.barButtonGroup1.MenuAppearance.MenuCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.barButtonGroup1.MenuAppearance.MenuCaption.Options.UseFont = true;
            this.barButtonGroup1.MenuAppearance.SideStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
            this.barButtonGroup1.MenuAppearance.SideStrip.Options.UseFont = true;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.SpecificationsNumber);
            this.groupControl1.Controls.Add(this.Specification);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Sender);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 53);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(302, 102);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Константы печати";
            // 
            // SpecificationsNumber
            // 
            this.SpecificationsNumber.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.SpecificationsNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SpecificationsNumber.Location = new System.Drawing.Point(140, 79);
            this.SpecificationsNumber.Name = "SpecificationsNumber";
            this.SpecificationsNumber.Size = new System.Drawing.Size(150, 13);
            this.SpecificationsNumber.TabIndex = 14;
            this.SpecificationsNumber.Text = "ТУ У 24.7-05763429-030:2008";
            // 
            // Specification
            // 
            this.Specification.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.Specification.Location = new System.Drawing.Point(86, 53);
            this.Specification.MenuManager = this.ribbon;
            this.Specification.Name = "Specification";
            this.Specification.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Specification.Size = new System.Drawing.Size(204, 20);
            this.Specification.TabIndex = 13;
            this.Specification.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonEdit_ButtonClick);
            this.Specification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonEdit_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "ТУ У";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Отправитель";
            // 
            // Sender
            // 
            this.Sender.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.Sender.Location = new System.Drawing.Point(86, 25);
            this.Sender.MenuManager = this.ribbon;
            this.Sender.Name = "Sender";
            this.Sender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Sender.Size = new System.Drawing.Size(204, 20);
            this.Sender.TabIndex = 10;
            this.Sender.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonEdit_ButtonClick);
            this.Sender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonEdit_KeyDown);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.BreakedComplectation);
            this.groupControl2.Controls.Add(this.PostedComplectation);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 155);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(302, 75);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Константы цвета";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(136, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Прерванная комплектация";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Завершенная комплектация";
            // 
            // BreakedComplectation
            // 
            this.BreakedComplectation.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.BreakedComplectation.EditValue = System.Drawing.Color.Empty;
            this.BreakedComplectation.Location = new System.Drawing.Point(161, 51);
            this.BreakedComplectation.MenuManager = this.ribbon;
            this.BreakedComplectation.Name = "BreakedComplectation";
            this.BreakedComplectation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BreakedComplectation.Size = new System.Drawing.Size(129, 20);
            this.BreakedComplectation.TabIndex = 1;
            this.BreakedComplectation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SelectColor);
            this.BreakedComplectation.EditValueChanged += new System.EventHandler(this.ColorChanged);
            // 
            // PostedComplectation
            // 
            this.PostedComplectation.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.PostedComplectation.EditValue = System.Drawing.Color.Empty;
            this.PostedComplectation.Location = new System.Drawing.Point(161, 25);
            this.PostedComplectation.MenuManager = this.ribbon;
            this.PostedComplectation.Name = "PostedComplectation";
            this.PostedComplectation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.PostedComplectation.Size = new System.Drawing.Size(129, 20);
            this.PostedComplectation.TabIndex = 0;
            this.PostedComplectation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SelectColor);
            this.PostedComplectation.EditValueChanged += new System.EventHandler(this.ColorChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.imageEdit1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 230);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(302, 51);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Картинка текса по умолчанию";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Картинка текса";
            // 
            // imageEdit1
            // 
            this.imageEdit1.Location = new System.Drawing.Point(99, 25);
            this.imageEdit1.MenuManager = this.ribbon;
            this.imageEdit1.Name = "imageEdit1";
            this.imageEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.imageEdit1.Properties.PopupFormSize = new System.Drawing.Size(50, 50);
            this.imageEdit1.Properties.PopupSizeable = false;
            this.imageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imageEdit1.Size = new System.Drawing.Size(191, 20);
            this.imageEdit1.TabIndex = 0;
            this.imageEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.imageEdit1_ButtonClick);
            // 
            // ConstsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 304);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 305);
            this.Name = "ConstsForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Настройки системы";
            this.Load += new System.EventHandler(this.Itemform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Itemform_KeyDown);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.ribbon ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Specification.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.Sender.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.BreakedComplectation.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.PostedComplectation.Properties ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.groupControl3 ) ).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.imageEdit1.Properties ) ).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem OKButton;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl SpecificationsNumber;
        private DevExpress.XtraEditors.ButtonEdit Specification;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit Sender;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ColorEdit BreakedComplectation;
        private DevExpress.XtraEditors.ColorEdit PostedComplectation;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ImageEdit imageEdit1;
        }
    }