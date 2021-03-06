﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aramis.Enums;
using DevExpress.XtraBars;
using Aramis.UI.WinFormsDevXpress;
using Aramis.UI;
using Aramis.Core;

namespace Documents.Forms
    {
    [Aramis.Attributes.View(ViewType = ViewFormType.DocItem, DBObjectGuid = "009CD186-D21A-4AF3-BD81-A4B7E8D1B38B")]
    public partial class ShipmentItemForn : DevExpress.XtraBars.Ribbon.RibbonForm, IItemForm
        {
        #region Поля
        public DatabaseObject Item { get; set; }

        public Shipment Document
            {
            get { return (Shipment)Item; }
            }
        #endregion

        public ShipmentItemForn()
            {
            InitializeComponent();
            }

        private void OK_ItemClick(object sender, ItemClickEventArgs e)
            {
            WritingResult result = Write();
            if (result == WritingResult.Success)
                {
                Close();
                }
            }

        private WritingResult Write()
            {
            return Item.Write();
            }

        private void Write_ItemClick(object sender, ItemClickEventArgs e)
            {
            Write();
            }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
            {
            TryCancel();
            }

        private void TryCancel()
            {
            Close();
            }

        private void gridView1_DoubleClick(object sender, EventArgs e)
            {
            ShowPallet();
            }

        private void ShowPallet()
            {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
                {
                Aramis.UI.UserInterface.Current.ShowItem("Pallet", (long)row["Pallet"]);
                }
            }

        private void ShowPalletButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            ShowPallet();
            }

        }
    }