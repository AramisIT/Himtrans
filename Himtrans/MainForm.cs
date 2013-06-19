using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Catalogs;
using Catalogs.Forms;
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
using Aramis.CommonForms;
using Aramis.Enums;
using Aramis.Core;
using Aramis.UI.WinFormsDevXpress;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using Aramis.UI.WinFormsDevXpress.Forms.Documents;
using Documents;
using Catalogs.Predefined;
using Documents.Forms;

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

        // Иконка в трее

        private NotifyIcon TrayIcon;
        const string ITEM_SHOW_WINDOW = "Перейти в обычный режим";

        private const string WARNING_1 = "Не найден следующий файл:\r\n{0}";

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
        /// Список справочников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
            {
            Aramis.UI.UserInterface.Current.ShowObjectSelectingView(AramisObjectType.Catalog);
            }

        private void MainForm_Load(object sender, EventArgs e)
            {

            if (File.Exists(SystemAramis.APPLICATION_PATH + "\\version"))
                {
                UpdatePageGroup.Text = String.Format("Обновление {0}", File.ReadAllText(SystemAramis.APPLICATION_PATH + "\\version"));
                }

            if (SystemAramis.CurrentUser != null)
                {
                UIConsts.Skin = SystemAramis.CurrentUser.Skin;
                adminRibbonPage.Visible = SystemAramis.CurrentUser.Ref == Catalogs.CatalogUsers.Admin;
                if (SystemAramis.CurrentUser.Roles.IsContain(Predefined.SuperUser.Id, "Role") || SystemAramis.CurrentUser.Ref == Catalogs.CatalogUsers.Admin)
                    {
                    DBObjectsPageGroup.Visible = true;
                    }
                }

            CreateTrayIcon();
            CheckNewTaskTimer.Enabled = true;

            Jornal J = new Jornal();
            J.Date = DateTime.Now;
            J.Event = Enums.Events.LogIn;
            J.Description = "Вход в систему";
            J.Write();
            }

        /// <summary>
        /// Список документов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
            {
            Aramis.UI.UserInterface.Current.ShowObjectSelectingView(AramisObjectType.Document);
            }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
            {
            Close();
            }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
            {
            var dt = Aramis.SystemConfigurations.SystemCheckers.SystemChecker.CheckItemsForms();
            foreach (DataRow dr in dt.Rows)
                {
                string.Format("Объект {0}, контрол {1}. Тип контрола ({2}) не соответствует типу свойства ({3})", dr["ObjectName"], dr["ControlName"], dr["AllowDataTypeName"], dr["PropertyType"]).AlertBox();
                }
            }

        private void constsEditBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
            {
            (new Catalogs.Forms.ConstsForm()).Show();
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
            if (System.IO.File.Exists(iconPath))
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
            if (WindowState == FormWindowState.Minimized)
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

            for (int i = 0; i < menu.MenuItems.Count; i++)
                {
                menu.MenuItems[i].Click += new EventHandler((object sender, EventArgs e) =>
                    {
                        MenuItem menuItem = sender as MenuItem;
                        switch (menuItem.Text)
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
            new DeleteMarkedObjectsForm().Show();
            }

        #region Обновление

        private void UpdateDBStructureButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            PlatformMethods.UpdateDB(true);
            }

        private void UploadFilesToDBButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            PlatformMethods.UpdateSolution();
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
            CatalogsViewer viewer = new CatalogsViewer(Ribbon.SelectedPage.Text, "InterfacePages");
            Catalogs.InterfacePages page = (Catalogs.InterfacePages)new Catalogs.InterfacePages().Read(viewer.Id);
            new HelpForm().ShowPage(String.Format("{0}\\Help\\{1}", SystemAramis.APPLICATION_PATH, page.HelpFile.FileName));
            }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
            {
            PlatformMethods.UpdateDB(false);
            }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
            Jornal J = new Jornal();
            J.Date = DateTime.Now;
            J.Event = Enums.Events.LogOut;
            J.Description = "Выход из системы";
            J.Write();
            RemoveTrayIcon();
            }

        private void barButtonItem51_ItemClick_1(object sender, ItemClickEventArgs e)
            {
            PlatformMethods.UploadLoaderFiles(true);
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

        private void TestBarButtou_ItemClick(object sender, ItemClickEventArgs e)
            {

            }

        private void StandartPackButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Pallet newItem = new Pallet();
            newItem.Complectation = ComplectationType.Standart;
            newItem.FillFromTemplate();
            //Aramis.UI.UserInterface.Current.ShowSystemObject(newItem, new PalletItemForm());
            Aramis.UI.UserInterface.Current.ShowItem(newItem);
            }

        private void GroupPackButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Pallet newItem = new Pallet();
            newItem.Complectation = ComplectationType.Group;
            newItem.FillFromTemplate();
            Aramis.UI.UserInterface.Current.ShowItem(newItem);
            }

        private void RenewingPackButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Aramis.UI.UserInterface.Current.ShowList(typeof(Documents.Pallet), true);
            }

        private void ConstsButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            UserInterface.Current.ShowSystemObject(SystemConsts.GetEntity(), new ConstsForm());
            }

        private void JornalButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            UI.UserInterface.Current.ShowList(typeof(Documents.Jornal));
            }


        public bool AutoStartMode
            {
            get;
            set;
            }

        public void OnAutoStart()
            {
            }

        public Action ShowConnectionTroublesForm
            {
            get;
            set;
            }
        }
    }