using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Aramis.UI.WinFormsDevXpress;
using Aramis.UI;
using DatabaseObjects;
using Aramis.Enums;

namespace Documents.Forms
    {
    [View(ViewType = ViewFormType.DocItem, DBObjectGuid = "054BADEB-D84B-4771-A40C-C651409B9A2E")]
    public partial class PalletItemForm : DevExpress.XtraBars.Ribbon.RibbonForm, IItemForm
        {
        #region Поля
        public DatabaseObject Item { get; set; }

        public Pallet Document
            {
            get { return ( Pallet ) Item; }
            }
        #endregion

        public PalletItemForm()
            {
            InitializeComponent();
            }

        private void EnterWeightButton_Click(object sender, EventArgs e)
            {
            
            }

        private void StartButton_Click(object sender, EventArgs e)
            {
            if ( !Document.IsNew && !PackingRenewalButton.Down )
                {
                Pallet pallet = new Pallet();
                pallet.PalletNumber = Document.PalletNumber;
                pallet.Tex = Document.Tex;
                pallet.Shipment = Document.Shipment;
                pallet.Complectation = Document.Complectation;
                pallet.CurrentShift = Document.CurrentShift;
                pallet.PrintLabel = Document.PrintLabel;
                pallet.PrintLenght = Document.PrintLenght;
                pallet.BobbinCount = Document.BobbinCount;
                Item = pallet;
                Document.InitBeforeShowing();
                }
            Document.StartNewPallet();
            ItemFormTuner.SetReadOnlyProperty(this);
            StartButton.Enabled = false;
            SetReadonlyBarItems(false);
            }

        private void PalletItemForm_Shown(object sender, EventArgs e)
            {
            bool isGroup = Document.Complectation == ComplectationType.Group;
            label8.Visible = isGroup;
            BobbinCount.Visible = isGroup;
            if ( Document.Posted )
                {                
                PackingRenewalButton.Enabled = false;
                PackingEndButton.Enabled = false;
                StartButton.Enabled = false;
                }
            else if (!Document.IsNew)
                {
                PackingRenewalButton.Down = true;
                ItemFormTuner.SetReadOnlyProperty(this);
                }
            SetReadonlyBarItems(true);
            }

        private void SetReadonlyBarItems(bool readOnly)
            {
            ManualEnteringButton.Enabled = !readOnly;
            BobbinRemovingButton.Enabled = !readOnly;
            PackingBreakButton.Enabled = !readOnly;
            }

        private void PackingEndButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Document.Posted = true;
            Document.Write();
            EnterWeightButton.Visible = false;
            PackingRenewalButton.Enabled = false;
            StartButton.Enabled = true;
            SetReadonlyBarItems(true);
            DisableReadonlyProperties();
            }

        private void PackingBreakButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Document.EndPacking();
            PackingRenewalButton.Down = true;
            PackingRenewalButton.Enabled = true;
            EnterWeightButton.Visible = false;
            StartButton.Enabled = true;
            SetReadonlyBarItems(true);
            }

        private void DisableReadonlyProperties()
            {
            SortedDictionary<string, bool> properties = new SortedDictionary<string,bool>();
            properties.Add("Tex", false);
            properties.Add("comboBoxEdit1", false);
            properties.Add("PrintLabel", false);
            properties.Add("PrintLenght", false);
            properties.Add("PackType", false);
            properties.Add("Shipment", false);
            properties.Add("PalletNumber", false);
            properties.Add("BobbinCount", false);
            properties.Add("CurrentShift", false);
            ItemFormTuner.SetReadOnlyStatus(this, false, properties);
            }

        private void PackingRenewalButton_DownChanged(object sender, ItemClickEventArgs e)
            {
            if ( !PackingRenewalButton.Down )
                {
                DisableReadonlyProperties();
                }

            if ( Document.IsNew || Document.IsModified )
                {                
                PackingRenewalButton.Down = false;
                PackingRenewalButton.Enabled = false;
                }
            }
        }
    }