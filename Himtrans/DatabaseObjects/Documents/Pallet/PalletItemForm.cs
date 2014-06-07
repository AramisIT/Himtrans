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
using DevExpress.XtraGrid.Views.Grid;
using Aramis.Platform;
using Aramis.DatabaseConnector;

namespace Documents.Forms
{
    [View(ViewType = ViewFormType.DocItem, DBObjectGuid = "054BADEB-D84B-4771-A40C-C651409B9A2E")]
    public partial class PalletItemForm : DevExpress.XtraBars.Ribbon.RibbonForm, IItemForm
    {
        #region Поля
        public DatabaseObject Item { get; set; }

        public Pallet Document
        {
            get { return (Pallet)Item; }
        }


        #endregion

        public PalletItemForm()
        {
            InitializeComponent();
        }

        private void EnterWeightButton_Click(object sender, EventArgs e)
        {
            Document.WeightGetting();
            CurrentWeight.Focus();
            CurrentWeight.SelectAll();
        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            bool start = true;
            WinFormsDevX.GetItemFormsByGuid(Document.GUID).ForEach(form =>
                {
                    if (!form.Equals(this))
                    {
                        if (!((PalletItemForm)form).BreakWeightGetting())
                        {
                            form.Focus();
                            start = false;
                        }
                    }
                });

            if (!PackingRenewalButton.Down)
            {
                Query query = DB.NewQuery("select Id from pallet where Shipment = @Shipment and PalletNumber = @PalletNumber and MarkForDeleting = 0");
                query.AddInputParameter("Shipment", Document.Shipment);
                query.AddInputParameter("PalletNumber", Document.PalletNumber);
                object result = query.SelectScalar();
                if (result != null)
                {
                    "Номер палеты не уникален в пределах партии!".WarningBox();
                    start = false;
                }

            }

            if (!start)
            {
                return;
            }
            if (!Document.IsNew && !PackingRenewalButton.Down)
            {
                Document.InitNewDateAndNumber();
            }

            if (Document.StartNewPallet())
            {
                ItemFormTuner.SetReadOnlyProperty(this);
                DisableRadonlyBobbinsAndCheckBoxes();
                StartButton.Enabled = false;
                SetReadonlyBarItems(false);
                PackingEndButton.Enabled = true;
                RePrintingButton.Enabled = true;
            }
        }

        private void PalletItemForm_Shown(object sender, EventArgs e)
        {
            RePrintingButton.Enabled = !Document.IsNew;
            PackingEndButton.Enabled = !Document.IsNew;
            Document.OnWeightGetting += new OnWeightGettingDelegate(Document_OnWeightGetting);
            bool isGroup = Document.Complectation == ComplectationType.Group;
            label8.Visible = isGroup;
            BobbinCount.Visible = isGroup;
            if (Document.Posted)
            {
                StartButton.Enabled = false;
                ItemFormTuner.SetReadOnlyProperty(this);
                DisableRadonlyBobbinsAndCheckBoxes();
                ShipingRePrintingButton.Enabled = true;
            }
            else if (!Document.IsNew)
            {
                PackingEndButton.Enabled = true;
                ItemFormTuner.SetReadOnlyProperty(this);
                DisableRadonlyBobbinsAndCheckBoxes();
            }
            SetReadonlyBarItems(true);
        }

        void Document_OnWeightGetting(long number)
        {
            if (this.InvokeRequired)
            {
                object[] param = new object[1];
                param[1] = number;
                this.Invoke(new OnWeightGettingDelegate(Document_OnWeightGetting), param);
            }
            else
            {
                LBCurrentBabin.ForeColor = Color.Red;
                ChangeFontTimer.Enabled = true;
                LBCurrentBabin.Text = number.ToString();
            }
        }

        private void SetReadonlyBarItems(bool readOnly)
        {
            ManualEnteringButton.Enabled = !readOnly;
            BobbinRemovingButton.Enabled = !readOnly;
            PackingBreakButton.Enabled = !readOnly;
            PackingRenewalButton.Enabled = readOnly && !Document.IsNew && !Document.Posted;
            PackingRenewalButton.Down = !Document.IsNew && !Document.Posted;
        }

        private void PackingEndButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Document.EndPacking())
            {
                EnterWeightButton.Visible = false;
                ShipingRePrintingButton.Enabled = true;
                StartButton.Enabled = true;
                SetReadonlyBarItems(true);
                DisableReadonlyProperties();
                PackingEndButton.Enabled = false;
                PackingRenewalButton.Enabled = false;
            }
        }

        private void PackingBreakButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            BreakWeightGetting();
        }

        private void DisableReadonlyProperties()
        {
            SortedDictionary<string, bool> properties = new SortedDictionary<string, bool>();
            properties.Add("Tex", false);
            properties.Add("Shipment", false);
            properties.Add("PalletNumber", false);
            properties.Add("BobbinCount", false);
            properties.Add("CurrentShift", false);
            properties.Add("BobbinsControl", false);
            properties.Add("Sender", false);
            properties.Add("PrintVirtualWeight", false);
            properties.Add("VirtualWeight", false);
            ItemFormTuner.SetReadOnlyStatus(this, false, properties);
        }

        private void DisableRadonlyBobbinsAndCheckBoxes()
        {
            SortedDictionary<string, bool> properties = new SortedDictionary<string, bool>();
            properties.Add("PrintLabel", false);
            properties.Add("PrintLenght", false);
            properties.Add("Bobbins", false);
            properties.Add("PackType", false);
            properties.Add("Counter", false);
            ItemFormTuner.SetReadOnlyStatus(this, false, properties);
        }

        private void PackingRenewalButton_DownChanged(object sender, ItemClickEventArgs e)
        {
            if (Document.IsNew || Document.IsModified)
            {
                PackingRenewalButton.Down = false;
                PackingRenewalButton.Enabled = false;
            }

            if (!PackingRenewalButton.Down)
            {
                DisableReadonlyProperties();
                StartButton.Text = "Начать";
            }
            else
            {
                ItemFormTuner.SetReadOnlyProperty(this);
                DisableRadonlyBobbinsAndCheckBoxes();
                StartButton.Text = "Продолжить";
            }
        }

        private void ChangeFontTimer_Tick(object sender, EventArgs e)
        {
            LBCurrentBabin.ForeColor = Color.Black;
            ((Timer)sender).Enabled = false;
        }

        private void ManualEnteringButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Jornal J = new Jornal();
            J.Date = DateTime.Now;
            J.Event = Aramis.Enums.Events.ManualEntering;
            J.Description = String.Format("Начат ручной ввод");
            J.Pallet = Document;
            J.Write();

            ManualEnteringButton.Enabled = false;
            EnterWeightButton.Visible = true;
            CurrentWeight.Properties.ReadOnly = false;
            CurrentWeight.Focus();
            CurrentWeight.SelectAll();
        }

        private void PalletItemForm_Load(object sender, EventArgs e)
        {
            if (Document != null)
            {
                Document.OnPalletAdded += new Action(Document_OnPalletAdded);
            }
        }

        void Document_OnPalletAdded()
        {
            try
            {
                if (Document.Bobbins.Rows.Count > 0)
                {
                    int rowHandle = gridView1.GetRowHandle(Document.Bobbins.Rows.Count - 1);
                    gridView1.MakeRowVisible(rowHandle, false);
                }
            }
            catch { }
        }

        public bool BreakWeightGetting()
        {
            if (Document.BreakPacking())
            {
                EnterWeightButton.Visible = false;
                StartButton.Enabled = true;
                SetReadonlyBarItems(true);
                return true;
            }
            return false;
        }

        private void BobbinRemovingButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemFormTuner.RemoveSubtableRow(((GridView)BobbinsControl.MainView).GetDataRow(((GridView)BobbinsControl.MainView).FocusedRowHandle), Document);
        }

        private void BobbinsControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && Document.Started)
            {
                ItemFormTuner.RemoveSubtableRow(((GridView)BobbinsControl.MainView).GetDataRow(((GridView)BobbinsControl.MainView).FocusedRowHandle), Document);
            }
        }

        private void PalletItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !BreakWeightGetting();
        }

        private void RePrintingButton_ItemClick(object sender, ItemClickEventArgs e)
        {

            Document.RePrint();
        }

        private void ShipingRePrinting_ItemClick(object sender, ItemClickEventArgs e)
        {
            Jornal J = new Jornal();
            J.Date = DateTime.Now;
            J.Event = Aramis.Enums.Events.RePrinting;
            J.Description = "Повторная печать спецификации";
            J.Pallet = Document;
            J.Write();
            Document.PrintShipment();
        }
    }
}