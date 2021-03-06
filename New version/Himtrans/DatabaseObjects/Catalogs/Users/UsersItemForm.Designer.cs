namespace Aramis.CommonForms
{
    partial class UsersItemForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersItemForm));
        this.DescriptionControl = new DevExpress.XtraEditors.TextEdit();
        this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
        this.OK = new DevExpress.XtraBars.BarButtonItem();
        this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
        this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
        this.detach = new DevExpress.XtraBars.BarButtonItem();
        this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
        this.RolesButtonsBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
        this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
        this.MainPage = new DevExpress.XtraTab.XtraTabPage();
        this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
        this.DefaultInterfaceControl = new DevExpress.XtraEditors.ButtonEdit();
        this.stringMobilePhone = new DevExpress.XtraEditors.TextEdit();
        this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
        this.MobilePhoneLabel = new DevExpress.XtraEditors.LabelControl();
        this.ParentId = new DevExpress.XtraEditors.ButtonEdit();
        this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
        this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
        this.Skin = new DevExpress.XtraEditors.ComboBoxEdit();
        this.EnteringToSystemPage = new DevExpress.XtraTab.XtraTabPage();
        this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
        this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
        this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
        this.RepeatedPassword = new DevExpress.XtraEditors.TextEdit();
        this.EnteredPassword = new DevExpress.XtraEditors.TextEdit();
        this.LoginControl = new DevExpress.XtraEditors.TextEdit();
        this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
        this.RolesControl = new DevExpress.XtraGrid.GridControl();
        this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
        this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
        this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
        this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
        this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.DescriptionControl.Properties ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.ribbon ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.xtraTabControl ) ).BeginInit();
        this.xtraTabControl.SuspendLayout();
        this.MainPage.SuspendLayout();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.DefaultInterfaceControl.Properties ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.stringMobilePhone.Properties ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.ParentId.Properties ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.Skin.Properties ) ).BeginInit();
        this.EnteringToSystemPage.SuspendLayout();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.RepeatedPassword.Properties ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.EnteredPassword.Properties ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.LoginControl.Properties ) ).BeginInit();
        this.xtraTabPage2.SuspendLayout();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.RolesControl ) ).BeginInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.gridView1 ) ).BeginInit();
        this.SuspendLayout();
        // 
        // DescriptionControl
        // 
        this.DescriptionControl.Location = new System.Drawing.Point(157, 9);
        this.DescriptionControl.Name = "DescriptionControl";
        this.DescriptionControl.Properties.MaxLength = 66643;
        this.DescriptionControl.Size = new System.Drawing.Size(312, 20);
        this.DescriptionControl.TabIndex = 21;
        // 
        // ribbonStatusBar
        // 
        this.ribbonStatusBar.ItemLinks.Add(this.OK);
        this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem2);
        this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem3);
        this.ribbonStatusBar.ItemLinks.Add(this.detach);
        this.ribbonStatusBar.Location = new System.Drawing.Point(0, 220);
        this.ribbonStatusBar.Name = "ribbonStatusBar";
        this.ribbonStatusBar.Ribbon = this.ribbon;
        this.ribbonStatusBar.Size = new System.Drawing.Size(482, 23);
        // 
        // OK
        // 
        this.OK.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        this.OK.Caption = "OK";
        this.OK.Id = 0;
        this.OK.ImageIndex = 0;
        this.OK.Name = "OK";
        this.OK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OK_ItemClick);
        // 
        // barButtonItem2
        // 
        this.barButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        this.barButtonItem2.Caption = "Записать";
        this.barButtonItem2.Id = 1;
        this.barButtonItem2.Name = "barButtonItem2";
        this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Write_ItemClick);
        // 
        // barButtonItem3
        // 
        this.barButtonItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        this.barButtonItem3.Caption = "Отмена";
        this.barButtonItem3.Id = 2;
        this.barButtonItem3.ImageIndex = 1;
        this.barButtonItem3.Name = "barButtonItem3";
        this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
        // 
        // detach
        // 
        this.detach.Caption = "Открепить";
        this.detach.Id = 6;
        this.detach.Name = "detach";
        this.detach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.detach_ItemClick);
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
            this.OK,
            this.barButtonItem2,
            this.barButtonItem3,
            this.detach});
        this.ribbon.Location = new System.Drawing.Point(0, 0);
        this.ribbon.MaxItemId = 7;
        this.ribbon.Name = "ribbon";
        this.ribbon.Size = new System.Drawing.Size(482, 53);
        this.ribbon.StatusBar = this.ribbonStatusBar;
        this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
        // 
        // RolesButtonsBar
        // 
        this.RolesButtonsBar.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                    | System.Windows.Forms.AnchorStyles.Right ) ) );
        this.RolesButtonsBar.Dock = System.Windows.Forms.DockStyle.None;
        this.RolesButtonsBar.Location = new System.Drawing.Point(1, 0);
        this.RolesButtonsBar.Name = "RolesButtonsBar";
        this.RolesButtonsBar.Ribbon = this.ribbon;
        this.RolesButtonsBar.Size = new System.Drawing.Size(470, 23);
        // 
        // xtraTabControl
        // 
        this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.xtraTabControl.Location = new System.Drawing.Point(0, 53);
        this.xtraTabControl.Name = "xtraTabControl";
        this.xtraTabControl.SelectedTabPage = this.MainPage;
        this.xtraTabControl.Size = new System.Drawing.Size(482, 167);
        this.xtraTabControl.TabIndex = 12;
        this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.MainPage,
            this.EnteringToSystemPage,
            this.xtraTabPage2});
        // 
        // MainPage
        // 
        this.MainPage.Controls.Add(this.labelControl8);
        this.MainPage.Controls.Add(this.DefaultInterfaceControl);
        this.MainPage.Controls.Add(this.stringMobilePhone);
        this.MainPage.Controls.Add(this.labelControl5);
        this.MainPage.Controls.Add(this.MobilePhoneLabel);
        this.MainPage.Controls.Add(this.ParentId);
        this.MainPage.Controls.Add(this.labelControl7);
        this.MainPage.Controls.Add(this.labelControl4);
        this.MainPage.Controls.Add(this.DescriptionControl);
        this.MainPage.Controls.Add(this.Skin);
        this.MainPage.Name = "MainPage";
        this.MainPage.Size = new System.Drawing.Size(477, 141);
        this.MainPage.Text = "Настройка пользователя";
        // 
        // labelControl8
        // 
        this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl8.Location = new System.Drawing.Point(15, 116);
        this.labelControl8.Name = "labelControl8";
        this.labelControl8.Size = new System.Drawing.Size(65, 14);
        this.labelControl8.TabIndex = 32;
        this.labelControl8.Text = "Интерфейс";
        // 
        // DefaultInterfaceControl
        // 
        this.DefaultInterfaceControl.Location = new System.Drawing.Point(157, 113);
        this.DefaultInterfaceControl.MenuManager = this.ribbon;
        this.DefaultInterfaceControl.Name = "DefaultInterfaceControl";
        this.DefaultInterfaceControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
        this.DefaultInterfaceControl.Size = new System.Drawing.Size(311, 20);
        this.DefaultInterfaceControl.TabIndex = 31;
        // 
        // stringMobilePhone
        // 
        this.stringMobilePhone.Location = new System.Drawing.Point(156, 35);
        this.stringMobilePhone.Name = "stringMobilePhone";
        this.stringMobilePhone.Properties.Mask.EditMask = "\\+38 \\(0\\d\\d\\) \\d\\d\\d-\\d\\d-\\d\\d";
        this.stringMobilePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
        this.stringMobilePhone.Properties.MaxLength = 66643;
        this.stringMobilePhone.Size = new System.Drawing.Size(312, 20);
        this.stringMobilePhone.TabIndex = 26;
        // 
        // labelControl5
        // 
        this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl5.Location = new System.Drawing.Point(14, 90);
        this.labelControl5.Name = "labelControl5";
        this.labelControl5.Size = new System.Drawing.Size(54, 14);
        this.labelControl5.TabIndex = 23;
        this.labelControl5.Text = "Родитель";
        // 
        // MobilePhoneLabel
        // 
        this.MobilePhoneLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.MobilePhoneLabel.Location = new System.Drawing.Point(14, 38);
        this.MobilePhoneLabel.Name = "MobilePhoneLabel";
        this.MobilePhoneLabel.Size = new System.Drawing.Size(120, 14);
        this.MobilePhoneLabel.TabIndex = 25;
        this.MobilePhoneLabel.Text = "Мобильный телефон";
        // 
        // ParentId
        // 
        this.ParentId.Location = new System.Drawing.Point(156, 87);
        this.ParentId.Name = "ParentId";
        this.ParentId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
        this.ParentId.Size = new System.Drawing.Size(312, 20);
        this.ParentId.TabIndex = 15;
        // 
        // labelControl7
        // 
        this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl7.Location = new System.Drawing.Point(15, 64);
        this.labelControl7.Name = "labelControl7";
        this.labelControl7.Size = new System.Drawing.Size(107, 14);
        this.labelControl7.TabIndex = 23;
        this.labelControl7.Text = "Стиль интерфейса";
        // 
        // labelControl4
        // 
        this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl4.Location = new System.Drawing.Point(15, 12);
        this.labelControl4.Name = "labelControl4";
        this.labelControl4.Size = new System.Drawing.Size(123, 14);
        this.labelControl4.TabIndex = 22;
        this.labelControl4.Text = "Фамилия и инициалы";
        // 
        // Skin
        // 
        this.Skin.Location = new System.Drawing.Point(157, 61);
        this.Skin.Name = "Skin";
        this.Skin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
        this.Skin.Size = new System.Drawing.Size(312, 20);
        this.Skin.TabIndex = 20;
        this.Skin.SelectedIndexChanged += new System.EventHandler(this.Skin_Modified);
        // 
        // EnteringToSystemPage
        // 
        this.EnteringToSystemPage.Controls.Add(this.labelControl3);
        this.EnteringToSystemPage.Controls.Add(this.labelControl2);
        this.EnteringToSystemPage.Controls.Add(this.labelControl1);
        this.EnteringToSystemPage.Controls.Add(this.RepeatedPassword);
        this.EnteringToSystemPage.Controls.Add(this.EnteredPassword);
        this.EnteringToSystemPage.Controls.Add(this.LoginControl);
        this.EnteringToSystemPage.Name = "EnteringToSystemPage";
        this.EnteringToSystemPage.Size = new System.Drawing.Size(477, 145);
        this.EnteringToSystemPage.Text = "Вход в систему";
        // 
        // labelControl3
        // 
        this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl3.Location = new System.Drawing.Point(95, 79);
        this.labelControl3.Name = "labelControl3";
        this.labelControl3.Size = new System.Drawing.Size(105, 14);
        this.labelControl3.TabIndex = 16;
        this.labelControl3.Text = "Повторите пароль";
        // 
        // labelControl2
        // 
        this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl2.Location = new System.Drawing.Point(95, 53);
        this.labelControl2.Name = "labelControl2";
        this.labelControl2.Size = new System.Drawing.Size(80, 14);
        this.labelControl2.TabIndex = 15;
        this.labelControl2.Text = "Новый пароль";
        // 
        // labelControl1
        // 
        this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ));
        this.labelControl1.Location = new System.Drawing.Point(95, 13);
        this.labelControl1.Name = "labelControl1";
        this.labelControl1.Size = new System.Drawing.Size(34, 14);
        this.labelControl1.TabIndex = 14;
        this.labelControl1.Text = "Логин";
        // 
        // RepeatedPassword
        // 
        this.RepeatedPassword.Location = new System.Drawing.Point(212, 76);
        this.RepeatedPassword.Name = "RepeatedPassword";
        this.RepeatedPassword.Properties.PasswordChar = '*';
        this.RepeatedPassword.Size = new System.Drawing.Size(176, 20);
        this.RepeatedPassword.TabIndex = 13;
        this.RepeatedPassword.Enter += new System.EventHandler(this.Password_Enter);
        // 
        // EnteredPassword
        // 
        this.EnteredPassword.Location = new System.Drawing.Point(212, 50);
        this.EnteredPassword.Name = "EnteredPassword";
        this.EnteredPassword.Properties.PasswordChar = '*';
        this.EnteredPassword.Size = new System.Drawing.Size(176, 20);
        this.EnteredPassword.TabIndex = 12;
        this.EnteredPassword.Enter += new System.EventHandler(this.Password_Enter);
        // 
        // LoginControl
        // 
        this.LoginControl.Location = new System.Drawing.Point(212, 10);
        this.LoginControl.Name = "LoginControl";
        this.LoginControl.Properties.MaxLength = 25;
        this.LoginControl.Size = new System.Drawing.Size(176, 20);
        this.LoginControl.TabIndex = 11;
        // 
        // xtraTabPage2
        // 
        this.xtraTabPage2.Controls.Add(this.RolesButtonsBar);
        this.xtraTabPage2.Controls.Add(this.RolesControl);
        this.xtraTabPage2.Name = "xtraTabPage2";
        this.xtraTabPage2.Size = new System.Drawing.Size(477, 145);
        this.xtraTabPage2.Text = "Роли";
        // 
        // RolesControl
        // 
        this.RolesControl.Location = new System.Drawing.Point(1, 23);
        this.RolesControl.MainView = this.gridView1;
        this.RolesControl.Name = "RolesControl";
        this.RolesControl.Size = new System.Drawing.Size(480, 172);
        this.RolesControl.TabIndex = 0;
        this.RolesControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
        // 
        // gridView1
        // 
        this.gridView1.GridControl = this.RolesControl;
        this.gridView1.Name = "gridView1";
        this.gridView1.OptionsView.ShowGroupPanel = false;
        this.gridView1.OptionsView.ShowIndicator = false;
        // 
        // barButtonItem1
        // 
        this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        this.barButtonItem1.Caption = "OK";
        this.barButtonItem1.Id = 0;
        this.barButtonItem1.ImageIndex = 0;
        this.barButtonItem1.Name = "barButtonItem1";
        // 
        // barButtonItem4
        // 
        this.barButtonItem4.Caption = "Добавить новый элемент";
        this.barButtonItem4.Id = 2;
        this.barButtonItem4.LargeImageIndex = 2;
        this.barButtonItem4.Name = "barButtonItem4";
        // 
        // barButtonItem5
        // 
        this.barButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        this.barButtonItem5.Caption = "Записать";
        this.barButtonItem5.Id = 1;
        this.barButtonItem5.Name = "barButtonItem5";
        // 
        // barButtonItem6
        // 
        this.barButtonItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        this.barButtonItem6.Caption = "Отмена";
        this.barButtonItem6.Id = 2;
        this.barButtonItem6.ImageIndex = 1;
        this.barButtonItem6.Name = "barButtonItem6";
        // 
        // barButtonItem7
        // 
        this.barButtonItem7.Caption = "Закрыть";
        this.barButtonItem7.Id = 5;
        this.barButtonItem7.LargeImageIndex = 4;
        this.barButtonItem7.Name = "barButtonItem7";
        // 
        // UsersItemForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(482, 243);
        this.Controls.Add(this.xtraTabControl);
        this.Controls.Add(this.ribbonStatusBar);
        this.Controls.Add(this.ribbon);
        this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject("$this.Icon") ) );
        this.KeyPreview = true;
        this.MaximizeBox = false;
        this.MinimumSize = new System.Drawing.Size(488, 244);
        this.Name = "UsersItemForm";
        this.Ribbon = this.ribbon;
        this.StatusBar = this.ribbonStatusBar;
        this.Text = "Пользователи: ";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersItemForm_FormClosed);
        this.Load += new System.EventHandler(this.Itemform_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Itemform_KeyDown);
        ( ( System.ComponentModel.ISupportInitialize ) ( this.DescriptionControl.Properties ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.ribbon ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.xtraTabControl ) ).EndInit();
        this.xtraTabControl.ResumeLayout(false);
        this.MainPage.ResumeLayout(false);
        this.MainPage.PerformLayout();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.DefaultInterfaceControl.Properties ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.stringMobilePhone.Properties ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.ParentId.Properties ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.Skin.Properties ) ).EndInit();
        this.EnteringToSystemPage.ResumeLayout(false);
        this.EnteringToSystemPage.PerformLayout();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.RepeatedPassword.Properties ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.EnteredPassword.Properties ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.LoginControl.Properties ) ).EndInit();
        this.xtraTabPage2.ResumeLayout(false);
        ( ( System.ComponentModel.ISupportInitialize ) ( this.RolesControl ) ).EndInit();
        ( ( System.ComponentModel.ISupportInitialize ) ( this.gridView1 ) ).EndInit();
        this.ResumeLayout(false);

        }

        #endregion




        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem OK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.ButtonEdit ParentId;
        private DevExpress.XtraEditors.ComboBoxEdit Skin;
        private DevExpress.XtraEditors.TextEdit LoginControl;
        private DevExpress.XtraEditors.TextEdit RepeatedPassword;
        private DevExpress.XtraEditors.TextEdit EnteredPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit DescriptionControl;
        private DevExpress.XtraTab.XtraTabPage MainPage;
        private DevExpress.XtraTab.XtraTabPage EnteringToSystemPage;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraBars.BarButtonItem detach;
        private DevExpress.XtraGrid.GridControl RolesControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar RolesButtonsBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraEditors.LabelControl MobilePhoneLabel;
        private DevExpress.XtraEditors.TextEdit stringMobilePhone;
        private DevExpress.XtraEditors.ButtonEdit DefaultInterfaceControl;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
