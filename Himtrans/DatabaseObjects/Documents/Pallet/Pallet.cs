using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using DatabaseObjects;
using Catalogs;
using Aramis.Enums;
using System.Data;
using System.Drawing;
using Himtrans.WeightGetting;
using Aramis.UI.WinFormsDevXpress;
using Aramis.DatabaseConnector;
using Aramis.UI.DBObjectsListFilter;
using Labels;
using Catalogs.Forms;

namespace Aramis.Enums
    {
    public enum ComplectationType
        {
        [DataField(Description = "Стандарт")]
        Standart,
        [DataField(Description = "Групповая")]
        Group
        }

    public enum Shifts
        {
        [DataField(Description = "Первая")]
        First,
        [DataField(Description = "Вторая")]
        Second,
        [DataField(Description = "Третья")]
        Third,
        [DataField(Description = "Четвертая")]
        Fourth
        }

    public enum Counters
        {
        [DataField(Description = "90")]
        c90,
        [DataField(Description = "120")]
        c120
        }
    }

namespace Documents
    {
    public delegate void OnWeightGettingDelegate(long number);
    [Document(Description = "Паллета", GUID = "054BADEB-D84B-4771-A40C-C651409B9A2E")]
    public class Pallet : DocumentTable
        {
        #region Поля
        [DataField(Description = "Отправитель", ShowInList = true)]
        public Senders Sender
            {
            get
                {
                return (Senders)GetValueForObjectProperty("Sender");
                }
            set
                {
                SetValueForObjectProperty("Sender", value);
                }
            }

        [DataField(Description = "ТУ У", ShowInList = true)]
        public Specifications Specification
            {
            get
                {
                return (Specifications)GetValueForObjectProperty("Specification");
                }
            set
                {
                SetValueForObjectProperty("Specification", value);
                }
            }

        [DataField(Description = "Номер партии", ShowInList = true, NotEmpty = true, EditStyle = FieldEditStyle.AllowIncDec)]
        public int Shipment
            {
            get { return z_Shipment; }
            set
                {
                if (z_Shipment == value)
                    {
                    return;
                    }
                z_Shipment = value;
                NotifyPropertyChanged("Shipment");
                }
            }
        private int z_Shipment;

        [DataField(Description = "Текс", ShowInList = true, NotEmpty = true)]
        public Tex Tex
            {
            get
                {
                return (Tex)GetValueForObjectProperty("Tex");
                }
            set
                {
                SetValueForObjectProperty("Tex", value);
                }
            }

        [DataField(Description = "Вариант печати веса", StorageType = StorageTypes.Local, NotEmpty = false)]
        public WeightVariants WeightVariant
            {
            get
                {
                return (WeightVariants)GetValueForObjectProperty("WeightVariant");
                }
            set
                {
                SetValueForObjectProperty("WeightVariant", value);
                }
            }

        [DataField(Description = "Номер поддона", ShowInList = true, NotEmpty = true, EditStyle = FieldEditStyle.AllowIncDec)]
        public int PalletNumber
            {
            get { return z_PalletNumber; }
            set
                {
                if (z_PalletNumber == value)
                    {
                    return;
                    }
                z_PalletNumber = value;
                NotifyPropertyChanged("PalletNumber");
                }
            }
        private int z_PalletNumber;

        [DataField(Description = "Общий вес", ShowInList = true, DecimalPointsNumber = 3, ReadOnly = true)]
        public double TotalPalletWeight
            {
            get { return z_TotalPalletWeight; }
            set
                {
                if (z_TotalPalletWeight == value)
                    {
                    return;
                    }
                z_TotalPalletWeight = value;
                NotifyPropertyChanged("TotalPalletWeight");
                }
            }
        private double z_TotalPalletWeight;

        [DataField(Description = "Общий вес партии", DecimalPointsNumber = 3, StorageType = StorageTypes.Local, ReadOnly = true)]
        public double TotalShipmentWeight
            {
            get { return z_TotalShipmentWeight; }
            set
                {
                if (z_TotalShipmentWeight == value)
                    {
                    return;
                    }
                z_TotalShipmentWeight = value;
                NotifyPropertyChanged("TotalShipmentWeight");
                }
            }
        private double z_TotalShipmentWeight;

        [DataField(Description = "Количество бобин")]
        public int BobbinCount
            {
            get { return z_BobbinCount; }
            set
                {
                if (z_BobbinCount == value)
                    {
                    return;
                    }
                z_BobbinCount = value;
                NotifyPropertyChanged("BobbinCount");
                }
            }
        private int z_BobbinCount;

        [DataField(Description = "Тип комплектации", ShowInList = true)]
        public ComplectationType Complectation
            {
            get { return z_Complectation; }
            set
                {
                if (z_Complectation == value)
                    {
                    return;
                    }
                z_Complectation = value;
                NotifyPropertyChanged("Complectation");
                }
            }
        private ComplectationType z_Complectation;

        [DataField(Description = "Смена", StorageType = StorageTypes.Local, UseTemplate = true)]
        public Shifts CurrentShift
            {
            get { return z_CurrentShift; }
            set
                {
                if (z_CurrentShift == value)
                    {
                    return;
                    }
                z_CurrentShift = value;
                NotifyPropertyChanged("CurrentShift");
                }
            }
        private Shifts z_CurrentShift;

        [DataField(Description = "Печать этикетки", UseTemplate = true)]
        public bool PrintLabel
            {
            get { return z_PrintLabel; }
            set
                {
                if (z_PrintLabel == value)
                    {
                    return;
                    }
                z_PrintLabel = value;
                NotifyPropertyChanged("PrintLabel");
                }
            }
        private bool z_PrintLabel = true;

        [DataField(Description = "Печатать метраж", UseTemplate = true)]
        public bool PrintLenght
            {
            get { return z_PrintLenght; }
            set
                {
                if (z_PrintLenght == value)
                    {
                    return;
                    }
                z_PrintLenght = value;
                NotifyPropertyChanged("PrintLenght");
                }
            }
        private bool z_PrintLenght = true;

        [DataField(Description = "Печать условного веса", UseTemplate = true)]
        public bool PrintVirtualWeight
            {
            get { return z_PrintVirtualWeight; }
            set
                {
                if (z_PrintVirtualWeight == value)
                    {
                    return;
                    }
                z_PrintVirtualWeight = value;
                NotifyPropertyChanged("PrintVirtualWeight");
                }
            }
        private bool z_PrintVirtualWeight = false;

        [DataField(Description = "Счетчик", StorageType = StorageTypes.Local, UseTemplate = true)]
        public Counters Counter
            {
            get { return z_Counter; }
            set
                {
                if (z_Counter == value)
                    {
                    return;
                    }
                z_Counter = value;
                NotifyPropertyChanged("Counter");
                }
            }
        private Counters z_Counter;

        [DataField(Description = "Тип упаковки", UseTemplate = true)]
        public PackTypes PackType
            {
            get
                {
                return (PackTypes)GetValueForObjectProperty("PackType");
                }
            set
                {
                SetValueForObjectProperty("PackType", value);
                }
            }

        [DataField(Description = "Картинка текса", StorageType = StorageTypes.Local, ReadOnly = true)]
        public Image TexImage
            {
            get { return z_TexImage; }
            set
                {
                if (z_TexImage == value)
                    {
                    return;
                    }
                z_TexImage = value;
                NotifyPropertyChanged("TexImage");
                }
            }
        private Image z_TexImage;

        [DataField(Description = "Условный вес", DecimalPointsNumber = 1)]
        public double VirtualWeight
            {
            get { return z_VirtualWeight; }
            set
                {
                if (z_VirtualWeight == value)
                    {
                    return;
                    }
                z_VirtualWeight = value;
                NotifyPropertyChanged("VirtualWeight");
                }
            }
        private double z_VirtualWeight;

        [DataField(Description = "Вес бобины", StorageType = StorageTypes.Local, DecimalPointsNumber = 2, ReadOnly = true)]
        public double CurrentWeight
            {
            get { return z_CurrentWeight; }
            set
                {
                if (z_CurrentWeight == value)
                    {
                    return;
                    }
                z_CurrentWeight = value;
                NotifyPropertyChanged("CurrentWeight");
                }
            }
        private double z_CurrentWeight;

        [Table(Columns = "BobbinNumber, Weight, Shift, Customer, Inspection")]
        [DataField(Description = "Бобины")]
        public DataTable Bobbins
            {
            get
                {
                return GetSubtable("Bobbins");
                }
            }

        [SubTableField(Description = "Номер", PropertyType = typeof(int), ReadOnly = true)]
        public DataColumn BobbinNumber
            {
            get;
            set;
            }

        [SubTableField(Description = "Вес", PropertyType = typeof(double), ReadOnly = true, DecimalPointsNumber = 2)]
        public DataColumn Weight
            {
            get;
            set;
            }

        [SubTableField(Description = "Смена", PropertyType = typeof(Shifts), ReadOnly = true)]
        public DataColumn Shift
            {
            get;
            set;
            }

        [SubTableField(Description = "Заказчик", PropertyType = typeof(string))]
        public DataColumn Customer
            {
            get;
            set;
            }

        [SubTableField(Description = "Контроль", PropertyType = typeof(string))]
        public DataColumn Inspection
            {
            get;
            set;
            }
        #endregion

        private SortedSet<int> nextNumbers = new SortedSet<int>();
        private WeightGetting weightGetting = new WeightGetting(1);
        private int currentBobinNumber;
        private PalletPF palletPrintForm;
        private OneLabelPF bobbinPrintForm;
        private ShippingPF shipmentPrintForm;
        private bool isDebugMode = false;
        private long currentCounter;

        public Shipment ShipmentDoc
            {
            get;
            private set;
            }

        public bool Started
            {
            get
                {
                return weightGetting.Started;
                }
            }

        public event OnWeightGettingDelegate OnWeightGetting;

        public Pallet()
            : base()
            {
#if DEBUG
            isDebugMode = true;
#endif
            ValueOfObjectPropertyChanged += new ValueOfObjectPropertyChangedDelegate(Pallet_ValueOfObjectPropertyChanged);
            TableRowDeleted += new TableRowDeletedDelegate(Pallet_TableRowDeleted);
            weightGetting.OnWeightAccepted += new WeightAcceptedDelegate(weightGetting_OnWeightAccepted);
            PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Pallet_PropertyChanged);
            AfterWriting += new AfterWritingDelegate(Pallet_AfterWriting);
            }

        protected override void InitNewBeforeShowing()
            {
            while (Consts.Sender == null || Consts.Specification == null)
                {
                "Не заполнен отправитель или ТУ У.\r\nНеобходимо заполнить значения до начала работы!".WarningBox();
                new ConstsForm().ShowDialog();
                }
            Sender = Consts.Sender;
            Specification = Consts.Specification;
            }

        void Pallet_AfterWriting(DatabaseObject item)
            {
            if (!ShipmentDoc.Pallets.IsContain(this.Id, "Pallet"))
                {
                DataRow row = ShipmentDoc.Pallets.GetNewRow(ShipmentDoc);
                ItemFormTuner.SetRowValue(this.Id, row, ShipmentDoc.Pallet, ShipmentDoc);
                row.AddRowToTable(ShipmentDoc);
                ShipmentDoc.Write();
                }
            }

        void Pallet_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
            if (e.PropertyName == "Shipment")
                {
                if (this.Shipment < 0)
                    {
                    this.Shipment = 0;
                    }
                ShipmentDoc = new Documents.Shipment();
                ShipmentDoc.ReadByNumber(this.Shipment);
                if (!ShipmentDoc.IsNew)
                    {
                    Tex = ShipmentDoc.Tex;
                    }
                TotalShipmentWeight = ShipmentDoc.TotalShipmentWeight;
                }
            else if (e.PropertyName == "PrintLabel" || e.PropertyName == "PrintLenght" || e.PropertyName == "Counter" || e.PropertyName == "PackType")
                {
                IsObjectModified = false;
                }
            else if (e.PropertyName == "PalletNumber")
                {
                if (this.PalletNumber < 0)
                    {
                    this.PalletNumber = 0;
                    }
                }
            }

        void weightGetting_OnWeightAccepted(double value)
            {
            if (((System.Windows.Forms.Form)Aramis.Platform.UIConsts.MainWindow).InvokeRequired)
                {
                ((System.Windows.Forms.Form)Aramis.Platform.UIConsts.MainWindow).Invoke(new WeightAcceptedDelegate(weightGetting_OnWeightAccepted), new object[1] { value });
                }
            else
                {
                CurrentWeight = value;
                WeightGetting();
                }
            }

        void Pallet_TableRowDeleted(DataTable dataTable, DataRow currentRow)
            {
            Jornal J = new Jornal();
            J.Date = DateTime.Now;
            J.Event = Events.BobbinRemoving;
            J.Description = String.Format("Удаление бобины №{0}", currentRow[BobbinNumber]);
            J.Pallet = this;
            J.Write();

            nextNumbers.Add((int)currentRow[BobbinNumber]);
            TotalShipmentWeight -= (double)currentRow[Weight];
            TotalPalletWeight -= (double)currentRow[Weight];
            }

        void Pallet_ValueOfObjectPropertyChanged(string propertyName)
            {
            if (propertyName == "Tex")
                {
                this.TexImage = Tex.TexImage;
                }
            }

        public bool StartNewPallet()
            {
            if (ShipmentDoc != null)
                {
                if (ShipmentDoc.IsNew)
                    {
                    ShipmentDoc.Tex = Tex;
                    ShipmentDoc.Number = Shipment;
                    ShipmentDoc.Write();
                    }
                else
                    {
                    ShipmentDoc.Read();
                    if (ShipmentDoc.Tex.Id != Tex.Id)
                        {
                        Tex = ShipmentDoc.Tex;
                        }
                    }

                TotalShipmentWeight = ShipmentDoc.TotalShipmentWeight;
                TotalPalletWeight = 0;

                (from DataRow x in Bobbins.Rows select (double)x[Weight]).ToList<double>().ForEach(w => TotalPalletWeight += w);
                currentBobinNumber = ShipmentDoc.LastBobbinNumber;
                nextNumbers.Clear();
                }

            if (Write() == WritingResult.Success)
                {
                Jornal J = new Jornal();
                J.Date = CreationDate;
                J.Event = IsNew ? Events.Packing : Events.PackingRenewal;
                J.Description = String.Format("Партия №{0}; {2} №{1}", ShipmentDoc.Number, PalletNumber, IsNew ? "Начата комплектация" : "Доукомплектация паллеты");
                J.Pallet = this;
                J.Write();

                weightGetting.Start();
                currentCounter = Convert.ToInt64(new EnumsViewer((int)Counter, typeof(Counters)).ToString());
                return true;
                }
            return false;
            }

        public bool EndPacking()
            {
            string desc = "бобин";
            if (Complectation == ComplectationType.Group)
                {
                desc = "мешков";
                }

            if (String.Format("Количество {2} на поддоне: {0}\nОбщая вес: {1}\n\n{3}Завершить комплектацию и напечатать этикетку?",
                Bobbins.Rows.Count, TotalPalletWeight, desc,
                nextNumbers.Count != 0 ? "Имеются удаленные бобины!\r\n" : "").Ask() ||
                (Bobbins.Rows.Count == 120 &&
                    String.Format("Для спецификации допустимо максимум 120 бобин!\r\nПри продолжении спецификация будет напечатана не полностью!\r\nПрервать комплектацию?").Ask()))
                {
                Jornal J;
                if (nextNumbers.Count != 0)
                    {
                    J = new Jornal();
                    J.Date = CreationDate;
                    J.Event = Events.MissingBobbin;
                    StringBuilder bobbins = new StringBuilder();
                    foreach (int val in nextNumbers)
                        {
                        bobbins.AppendFormat(bobbins.Length == 0 ? "{0}" : ", {0}", val);
                        }
                    J.Description = String.Format("Отсутствующие бобины №", bobbins.ToString());
                    J.Pallet = this;
                    J.Write();
                    }

                Posted = true;
                Write();

                J = new Jornal();
                J.Date = CreationDate;
                J.Event = Events.PackingEnd;
                J.Description = String.Format("Партия №{0}; Завершена комплектация №{1}", ShipmentDoc.Number, PalletNumber);
                J.Pallet = this;
                J.Write();

                weightGetting.Stop();

                if (PrintLabel)
                    {
                    palletPrintForm = new PalletPF();
                    palletPrintForm.Fill(this);
                    PrintPalletLabel();
                    }

                if ("Печатать спецификацию?".Ask())
                    {
                    if (PrintLabel)
                        {
                        PrintShipment();
                        }
                    }

                return true;
                }
            return false;
            }

        public void PrintShipment()
            {
            shipmentPrintForm = new ShippingPF();
            shipmentPrintForm.Fill(this);

            string path = String.Format("Export\\{0}", Shipment);
            if (!System.IO.Directory.Exists(path))
                {
                System.IO.Directory.CreateDirectory(path);
                }

            if (isDebugMode)
                {
                shipmentPrintForm.ShowPreview();
                }
            else
                {
                shipmentPrintForm.Print();
                }
            shipmentPrintForm.ExportToXls(String.Format("{0}\\{1} #{2} {3}.xls", path, Date, Shipment, PalletNumber).Replace(':', '.'));
            String.Format("Документ \"{0} #{1} {2}.xls\" успешно создан", Date, Shipment, PalletNumber).Replace(':', '.').AlertBox();
            }

        private void PrintPalletLabel()
            {
            if (palletPrintForm == null)
                {
                palletPrintForm = new PalletPF();
                palletPrintForm.Fill(this);
                }
            if (isDebugMode)
                {
                palletPrintForm.ShowPreview();
                }
            else
                {
                palletPrintForm.Print();
                }
            }

        public bool BreakPacking()
            {
            if (Started)
                {
                if (String.Format("{3}\r\nПартия: {0}\r\nПоддон: {1}\r\n{2}Прервать комплектацию?", Shipment, PalletNumber,
                    nextNumbers.Count != 0 ? "Имеются удаленные бобины!\r\nПри возобновлении комплектации номера этих бобин будут пропущены.\r\n" : "", this.ToString()).Ask())
                    {
                    Jornal J = new Jornal();
                    J.Date = CreationDate;
                    J.Event = Events.PackingBreak;
                    J.Description = String.Format("Партия №{0}; Прервана комплектация №{1}", ShipmentDoc.Number, PalletNumber);
                    J.Pallet = this;
                    J.Write();

                    weightGetting.Stop();
                    return true;
                    }
                return false;
                }
            return true;
            }

        public event Action OnPalletAdded;

        public void WeightGetting()
            {
            if (weightGetting.Started)
                {
                DataRow row = Bobbins.GetNewRow(this);

                if (nextNumbers.Count > 0)
                    {
                    row[BobbinNumber] = nextNumbers.Min;

                    Jornal J = new Jornal();
                    J.Date = DateTime.Now;
                    J.Event = Events.ReWeighting;
                    J.Description = String.Format("Перевзвешивание бобины №{0}", nextNumbers.Min);
                    J.Pallet = this;
                    J.Write();

                    nextNumbers.Remove(nextNumbers.Min);
                    }
                else
                    {
                    currentBobinNumber++;
                    row[BobbinNumber] = currentBobinNumber;
                    }
                row[Weight] = CurrentWeight;
                ItemFormTuner.SetRowValue(CurrentShift, row, Shift, this);
                row.AddRowToTable(this);

                TotalPalletWeight += CurrentWeight;
                TotalShipmentWeight += CurrentWeight;
                if (Write() == WritingResult.Success)
                    {
                    if (OnWeightGetting != null)
                        {
                        OnWeightGetting((long)row[Subtable.LINE_NUMBER_COLUMN_NAME]);
                        }

                    if (PrintLabel)
                        {
                        bobbinPrintForm = new OneLabelPF();
                        bobbinPrintForm.Fill(this, getPrintableWeight(), currentBobinNumber);
                        PrintBobbinLabel();
                        }

                    if ((long)row[Subtable.LINE_NUMBER_COLUMN_NAME] == currentCounter || (long)row[Subtable.LINE_NUMBER_COLUMN_NAME] == 120)
                        {
                        EndPacking();
                        }
                    if (OnPalletAdded != null)
                        {
                        OnPalletAdded();
                        }
                    }
                }
            }


        private string getPrintableWeight()
            {
            bool printFixedWeight = WeightVariant != null && WeightVariant.Id > 0;
            if (printFixedWeight)
                {
                return WeightVariant.Description.Trim();
                }

            if (PrintVirtualWeight)
                {
                return VirtualWeight.ToString() + "±7%";
                }
            else
                {
                return Math.Round(CurrentWeight, 1).ToString();
                }
            }

        private void PrintBobbinLabel()
            {
            if (isDebugMode)
                {
                bobbinPrintForm.ShowPreview();
                }
            else
                {
                bobbinPrintForm.Print();
                }
            }

        public void RePrint()
            {
            Jornal J = new Jornal();
            J.Date = DateTime.Now;
            J.Event = Events.RePrinting;

            if (Started)
                {
                PrintBobbinLabel();
                J.Description = String.Format("Повторная печать этикетки бобины");
                }
            else
                {
                PrintPalletLabel();
                J.Description = String.Format("Повторная печать этикетки паллеты");
                }

            J.Pallet = this;
            J.Write();
            }

        public override GetListFilterDelegate GetFuncGetListFilter()
            {
            return () =>
                {
                    ListFilter filter = new ListFilter("Pallet");
                    filter.Conditions["Posted"].Active = true;
                    filter.Conditions["MarkForDeleting"].Active = true;
                    (filter.Conditions["Posted"] as ConditionForBool).Value.SingleValue = false;
                    (filter.Conditions["MarkForDeleting"] as ConditionForBool).Value.SingleValue = false;
                    return filter;
                };
            }

        public override GetRowColorDelegate GetFuncGetRowColor()
            {
            return (row) =>
                {
                    if ((bool)row["Posted"])
                        {
                        return Consts.PostedComplectation;
                        }
                    else
                        {
                        return Consts.BreakedComplectation;
                        }
                };
            }

        public void InitNewDateAndNumber()
            {
            Id = 0;
            Read();
            Posted = false;
            CurrentWeight = 0;
            Bobbins.Rows.Clear();
            InitNewBeforeShowing();
            }
        }
    }
