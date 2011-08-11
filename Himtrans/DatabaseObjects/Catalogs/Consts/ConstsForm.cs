using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DatabaseObjects;
using System.Linq;
using System.Reflection;
using Aramis;
using Aramis.UI;
using Aramis.SystemConfigurations;
using System.Collections.Generic;
using System;
using Catalogs;
using System.Drawing;
using System.Data;
using DevExpress.XtraTab;
using Aramis.Platform;
using Aramis.Enums;
using System.IO;

namespace Catalogs.Forms
    {
    public partial class ConstsForm : DevExpress.XtraBars.Ribbon.RibbonForm
        {
        private ColorDialog colorDialog = new ColorDialog();


        private void Itemform_Load(object sender, EventArgs e)
            {
            Aramis.UI.WinFormsDevXpress.WinFormsDevX.SetAllImages(ribbon);

            Sender.EditValue =Consts.Sender != null ? new CatalogsViewer(Consts.Sender) : null;
            Specification.EditValue =Consts.Specification != null ? new CatalogsViewer(Consts.Specification) : null;
            SpecificationsNumber.Text =Consts.Specification != null ? Consts.Specification.Number : "";
            PostedComplectation.Color = Consts.PostedComplectation;
            BreakedComplectation.Color = Consts.BreakedComplectation;
            imageEdit1.Image = Consts.DefaultTexImage;
            }

        #region Constructor

        public ConstsForm()
            {
            InitializeComponent();
            }

        #endregion

        private void Itemform_KeyDown(object sender, KeyEventArgs e)
            {
            switch ( e.KeyCode )
                {
                case Keys.Escape:
                    Close();
                    break;
                }
            }

        private void SelectColor(object sender, ButtonPressedEventArgs e)
            {
            colorDialog.Color = ( sender as ColorEdit ).Color;

            if ( colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
                {
                ( sender as ColorEdit ).Color = colorDialog.Color;
                }
            }

        private void OKButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Close();
            }

        private void ColorChanged(object sender, EventArgs e)
            {
            SetColor(( sender as ColorEdit ));
            }

        private void SetColor(ColorEdit sender)
            {
            switch ( sender.Name )
                {
                case "PostedComplectation":
                    Consts.PostedComplectation = sender.Color;
                    break;

                case "BreakedComplectation":
                    Consts.BreakedComplectation = sender.Color;
                    break;
                }
            }

        private void DateChanged(object sender, EventArgs e)
            {
            SetDate((DateEdit)sender);
            }

        private void SetDate(DateEdit dateEdit)
            {
            switch ( dateEdit.Name )
                {
                case "ClosingPeriodDate":
                    SystemConsts.ClosingPeriodDate = dateEdit.DateTime;
                    break;
                }
            }

        private void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
         if ( ( sender as ButtonEdit ).Properties.ReadOnly )
                        {
                        return;
                        }

                    if ( e.KeyCode == Keys.F4
                        && !e.Alt
                        //&& !e.Shift && !e.Control
                        )
                        {
                        DataBaseObjectSelecting(((ButtonEdit)sender).Name);
                        }
        }

        private void ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
        string propertyName = ( ( ButtonEdit ) sender ).Name;
        ButtonEdit buttonEdit = sender as ButtonEdit;
        switch ( e.Button.Kind )
            {
            case ButtonPredefines.Ellipsis:
                if ( buttonEdit.Properties.ReadOnly )
                    {
                    return;
                    }
                DataBaseObjectSelecting(propertyName);
                break;

            case ButtonPredefines.Delete:
                if ( buttonEdit.Properties.ReadOnly )
                    {
                    return;
                    }
                DataBaseObjectSelecting(propertyName);
                break;
            }
        }

        private void DataBaseObjectSelecting(string propertyName)
            {
            long itemId = -1;
            Guid propGuid = new Guid();
            switch (propertyName )
                {
                case "Sender":
                    itemId = Consts.Sender != null ? Consts.Sender.Id : 0;
                    propGuid = SystemConfiguration.DBConfigurationTree["Senders"].GUID;
                    break;
                case "Specification":
                    itemId = Consts.Specification != null ? Consts.Specification.Id : 0;
                    propGuid = SystemConfiguration.DBConfigurationTree["Specifications"].GUID;
                    break;
                }

                long newItemId = Aramis.UI.AbstructUI.UI.SelectItemFromList(propGuid, itemId, false);
                if ( newItemId == -1 )
                    {
                    return;
                    }
                switch ( propertyName )
                    {
                    case "Sender":
                        Consts.Sender = (Senders)new Senders().Read(newItemId);
                        Sender.EditValue = new CatalogsViewer(Consts.Sender);
                        break;
                    case "Specification":
                        Consts.Specification = (Specifications)new Specifications().Read(newItemId);
                        Specification.EditValue = new CatalogsViewer(Consts.Specification);
                        SpecificationsNumber.Text = Consts.Specification.Number;
                        break;
                    }
            }

        private void imageEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
            {
            ImageEdit img = ( sender as ImageEdit );
            if ( e.Button.Kind == ButtonPredefines.Ellipsis && !img.Properties.ReadOnly )
                {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.FileName = "";
                dialog.Multiselect = false;
                dialog.CheckFileExists = true;
                if ( dialog.ShowDialog() == DialogResult.OK )
                    {
                    try
                        {
                        byte[] bytes = File.ReadAllBytes(dialog.FileName);
                        img.Image = Image.FromStream(new MemoryStream(bytes));
                        img.Image.Tag = dialog.FileName;
                        Consts.DefaultTexImage = img.Image;
                        }
                    catch ( Exception exp )
                        {
                        String.Format("Ошибка при загрузке изображения.\r\nИнформация: {0}", exp.Message).WarningBox();
                        }
                    }
                }
            }

        }
    }