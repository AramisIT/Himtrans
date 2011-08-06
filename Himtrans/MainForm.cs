using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;
using Aramis.SystemConfigurations;
using Aramis.UI;
using Aramis.UI.WinFormsDevXpress.Forms;
using Aramis.NET;
using Aramis.Reports;
using System.IO;
using Aramis.Platform;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using Aramis.DatabaseConnector;
using Aramis.CommonForms;
using Aramis.Enums;
using DatabaseObjects;
using Aramis.UI.WinFormsDevXpress;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using Aramis.UI.WinFormsDevXpress.Forms.Documents;

namespace Aramis.GreenHouse
    {

    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm, IMainForm
        {
        new public UserLookAndFeel LookAndFeel
            {
            get
                {
                return defaultLookAndFeel.LookAndFeel;
                }
            }

        // ������ � ����

        private NotifyIcon TrayIcon;
        const string ITEM_SHOW_WINDOW = "������� � ������� �����";

        private const string WARNING_1 = "�� ������ ��������� ����:\r\n{0}";

        public ImageCollection SmallImagesCollection
            {
            get
                {
                return smallImagesCollection;
                }
            }

        public ImageCollection LargeImagesCollection
            {
            get
                {
                return largeImagesCollection;
                }
            }

        public MainForm()
            {
            InitializeComponent();
            }

        /// <summary>
        /// ������ ������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
            {
            AbstructUI.UI.ShowObjectSelectingView(AramisObjectType.Catalog);
            }

        private void MainForm_Load(object sender, EventArgs e)
            {

            if ( File.Exists(SystemAramis.APPLICATION_PATH + "\\version") )
                {
                UpdatePageGroup.Text = String.Format("���������� {0}", File.ReadAllText(SystemAramis.APPLICATION_PATH + "\\version"));
                }

            if ( SystemAramis.CurrentUser != null )
                {
                UIConsts.Skin = SystemAramis.CurrentUser.Skin;
                adminRibbonPage.Visible = SystemAramis.CurrentUser.Ref == Catalogs.CatalogUsers.Admin;
                //foreach ( DataRow row in SystemAramis.CurrentUser.Roles.Rows )
                //    {
                //    if ( ( long ) row["Role"] == Catalogs.Roles.SalaryManager.Id )
                //        {
                //        SalaryAdministrating.Visible = true;
                //        }

                //    }

                }

            CreateTrayIcon();
            CheckNewTaskTimer.Enabled = true;

            }

        /// <summary>
        /// ������ ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
            {
            AbstructUI.UI.ShowObjectSelectingView(AramisObjectType.Document);
            }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
            {
            Close();
            }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
            {
            var dt = Aramis.SystemConfigurations.SystemCheckers.SystemChecker.CheckItemsForms();
            foreach ( DataRow dr in dt.Rows )
                {
                string.Format("������ {0}, ������� {1}. ��� �������� ({2}) �� ������������� ���� �������� ({3})", dr[ "ObjectName" ], dr[ "ControlName" ], dr[ "AllowDataTypeName" ], dr[ "PropertyType" ]).AlertBox();
                }
            }

        private void constsEditBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
            {
            ( new ConstsForm() ).Show();
            }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
            {
            ToTray();
            }

        private void ToTray()
            {


            Hide();

            }

        private void CreateTrayIcon()
            {
            TrayIcon = new NotifyIcon();
            string iconPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\TrayIcon.ico";
            if ( System.IO.File.Exists(iconPath) )
                {
                TrayIcon.Icon = new Icon(iconPath);
                }
            else
                {
                string.Format(WARNING_1, iconPath).WarningBox();
                return;
                }

            TrayIcon.ContextMenu = CreateNotifyMenu();
            TrayIcon.Visible = true;
            }

        private void FromTray()
            {
            Show();
            if ( WindowState == FormWindowState.Minimized )
                {
                WindowState = FormWindowState.Maximized;
                }
            Activate();
            //Focus();
            //CheckNewTaskTimer.Enabled = false;
            }

        private void RemoveTrayIcon()
            {
            TrayIcon.Visible = false;
            TrayIcon.Dispose();
            }

        private ContextMenu CreateNotifyMenu()
            {
            ContextMenu menu = new ContextMenu(new MenuItem[] { new MenuItem(ITEM_SHOW_WINDOW) });

            for ( int i = 0; i < menu.MenuItems.Count; i++ )
                {
                menu.MenuItems[ i ].Click += new EventHandler((object sender, EventArgs e) =>
                    {
                        MenuItem menuItem = sender as MenuItem;
                        switch ( menuItem.Text )
                            {
                            case ITEM_SHOW_WINDOW:
                                FromTray();
                                break;
                            }
                    });
                }
            return menu;
            }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
            {
            new DatabaseObjects.DeleteMarkedObjectsForm().Show();
            }

        #region ����������
        private void barButtonItem8_ItemClick_2(object sender, ItemClickEventArgs e)
            {
            DBU.NewQuery("delete from isUpdate where action = 999").Execute();

            SystemAramis.IsUpdateMode = false;
            SystemAramis.ItIsInitiator = false;

            Text = "������� ���������� �������: ��������";
            }

        private void barButtonItem18_ItemClick_1(object sender, ItemClickEventArgs e)
            {
            bool isDebug = false;
#if DEBUG
            isDebug = true;
#endif

            if ( !isDebug && !SystemAramis.IsUpdateMode && String.Format("���� � ����� ����������!\r\n���������� �������� ����� {0} ������. \r\n����������?", DelayControl.EditValue).Ask() )
                {
                Text = "����� ����������!";
                SystemAramis.IsUpdateMode = true;
                SystemAramis.ItIsInitiator = true;
                DBU.NewQuery(String.Format("insert into isUpdate (begindate, action, delay, applicationname) values (getdate(), 999, {0}, '{1}')", DelayControl.EditValue.ToString(), Aramis.Platform.SystemSetup.SystemSetup.ApplicationName)).Execute();

                Thread ButtonsStateChecker = new Thread(ChangeButtonsState);
                ButtonsStateChecker.IsBackground = true;
                ButtonsStateChecker.Start();
                }
            else
                {
                "��������� ���������� �������� ������ � ������ ������!".AlertBox();
                }

            }

        private void ChangeButtonsState()
            {
            EnterUpdateModeButton.Enabled = false;
            while ( SystemAramis.IsUpdateMode && SystemAramis.ItIsInitiator )
                {
                if ( SystemAramis.UpdatingFinished )
                    ExitUpdateModeButton.Enabled = true;
                else
                    ExitUpdateModeButton.Enabled = false;

                if ( SystemAramis.UpdatingAllowed && SystemAramis.UpdatingFinished )
                    {
                    UpdateDBStructureButton.Enabled = true;
                    UploadFilesToDBButton.Enabled = true;
                    }
                else
                    {
                    UpdateDBStructureButton.Enabled = false;
                    UploadFilesToDBButton.Enabled = false;
                    }
                Thread.Sleep(500);
                }
            EnterUpdateModeButton.Enabled = true;
            ExitUpdateModeButton.Enabled = false;
            UpdateDBStructureButton.Enabled = false;
            UploadFilesToDBButton.Enabled = false;
            }

        private void UpdateDBStructureButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            SystemAramis.UpdatingFinished = false;
            new CheckSolutionDBStruct().Check(true);
            SystemAramis.UpdatingFinished = true;
            }

        private void UploadFilesToDBButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            UploadFilesToDBButton.Enabled = false;
            System.Threading.Thread updThread = new System.Threading.Thread(Aramis.Updating.Updating.Update);
            updThread.IsBackground = true;
            updThread.Start();
            }
        #endregion

        private void barButtonItem12_ItemClick_1(object sender, ItemClickEventArgs e)
            {

            new Permissions.DBObjectPermissionsForm().Show();
            }

        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
            {
            GC.Collect();
            }

        private void barButtonItem38_ItemClick_2(object sender, ItemClickEventArgs e)
            {
            ShowHelp();
            }

        private void ShowHelp()
            {
            DatabaseObjects.CatalogsViewer viewer = new DatabaseObjects.CatalogsViewer(Ribbon.SelectedPage.Text, "InterfacePages");
            Catalogs.InterfacePages page = ( Catalogs.InterfacePages ) new Catalogs.InterfacePages().Read(viewer.Id);
            new HelpForm().ShowPage(String.Format("{0}\\Help\\{1}", SystemAramis.APPLICATION_PATH, page.HelpFile.FileName));
            }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
            {
            SystemAramis.UpdatingFinished = false;
            new CheckSolutionDBStruct().Check(false);
            SystemAramis.UpdatingFinished = true;
            }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
            RemoveTrayIcon();
            }

        private void barButtonItem51_ItemClick_1(object sender, ItemClickEventArgs e)
            {
            new Aramis.Common_classes.Forms.UploadLoaderFiles().Show();
            }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
            {

            }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
            {

            }

        private void ribbon_Click(object sender, EventArgs e)
            {

            }
        }
    }