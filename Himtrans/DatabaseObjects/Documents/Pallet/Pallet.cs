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

namespace Aramis.Enums
    {
    public enum ComplectationType
        {
        [DataField(Description = "Стандарт")]
        Standart,
        [DataField(Description = "С колес")]
        FromWeels,
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
    }

namespace Documents
    {
    public delegate void TotalWeightChanged();
    [Document(Description = "Паллета", GUID = "054BADEB-D84B-4771-A40C-C651409B9A2E")]
    public class Pallet : DocumentTable
        {
        #region Поля
        [DataField(Description = "Отправитель", ShowInList = true)]
        public Senders Sender
            {
            get
                {
                return ( Senders ) GetValueForObjectProperty("Sender");
                }
            set
                {
                SetValueForObjectProperty("Sender", value);
                }
            }

        [DataField(Description = "Номер партии", ShowInList = true, NotEmpty = true, EditStyle = FieldEditStyle.AllowIncDec)]
        public int Shipment
            {
            get { return z_Shipment; }
            set
                {
                if ( z_Shipment == value )
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
                return ( Tex ) GetValueForObjectProperty("Tex");
                }
            set
                {
                SetValueForObjectProperty("Tex", value);
                }
            }

        [DataField(Description = "Номер поддона", ShowInList = true, NotEmpty = true)]
        public int PalletNumber
            {
            get { return z_PalletNumber; }
            set
                {
                if ( z_PalletNumber == value )
                    {
                    return;
                    }
                z_PalletNumber = value;
                NotifyPropertyChanged("PalletNumber");
                }
            }
        private int z_PalletNumber;

        [DataField(Description = "Общий вес", ShowInList = true, DecimalPointsNumber = 3)]
        public double TotalPalletWeight
            {
            get { return z_TotalPalletWeight; }
            set
                {
                if ( z_TotalPalletWeight == value )
                    {
                    return;
                    }
                z_TotalPalletWeight = value;
                NotifyPropertyChanged("TotalPalletWeight");
                }
            }
        private double z_TotalPalletWeight;

        [DataField(Description = "Общий вес партии", DecimalPointsNumber = 3, StorageType = StorageTypes.Local)]
        public double TotalShipmentWeight
            {
            get { return z_TotalShipmentWeight; }
            set
                {
                if ( z_TotalShipmentWeight == value )
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
                if ( z_BobbinCount == value )
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
                if ( z_Complectation == value )
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
                if ( z_CurrentShift == value )
                    {
                    return;
                    }
                z_CurrentShift = value;
                NotifyPropertyChanged("CurrentShift");
                }
            }
        private Shifts z_CurrentShift;

        [DataField(Description = "Печать этикетки", StorageType = StorageTypes.Local, UseTemplate = true)]
        public bool PrintLabel
            {
            get { return z_PrintLabel; }
            set
                {
                if ( z_PrintLabel == value )
                    {
                    return;
                    }
                z_PrintLabel = value;
                NotifyPropertyChanged("PrintLabel");
                }
            }
        private bool z_PrintLabel;

        [DataField(Description = "Печатать метраж", StorageType = StorageTypes.Local, UseTemplate = true)]
        public bool PrintLenght
            {
            get { return z_PrintLenght; }
            set
                {
                if ( z_PrintLenght == value )
                    {
                    return;
                    }
                z_PrintLenght = value;
                NotifyPropertyChanged("PrintLinght");
                }
            }
        private bool z_PrintLenght;

        [DataField(Description = "Тип упаковки", UseTemplate = true)]
        public PackTypes PackType
            {
            get
                {
                return ( PackTypes ) GetValueForObjectProperty("PackType");
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
                if ( z_TexImage == value )
                    {
                    return;
                    }
                z_TexImage = value;
                NotifyPropertyChanged("TexImage");
                }
            }
        private Image z_TexImage;

        [DataField(Description = "Вес бобины", StorageType = StorageTypes.Local, DecimalPointsNumber = 2, ReadOnly = true)]
        public double CurrentWeight
            {
            get { return z_CurrentWeight; }
            set
                {
                if ( z_CurrentWeight == value )
                    {
                    return;
                    }
                z_CurrentWeight = value;
                NotifyPropertyChanged("CurrentWeight");
                }
            }
        private double z_CurrentWeight;

        [Table(Columns = "BobbinNumber, Weight, Shift, Customer, Inspection")]
        [DataField(Description = "Бобины", ReadOnly = true)]
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

        [SubTableField(Description = "Заказчик", PropertyType = typeof(string), ReadOnly = true)]
        public DataColumn Customer
            {
            get;
            set;
            }

        [SubTableField(Description = "Контроль", PropertyType = typeof(string), ReadOnly = true)]
        public DataColumn Inspection
            {
            get;
            set;
            }
        #endregion

        private SortedSet<int> nextNumbers = new SortedSet<int>();
        private WeightGetting weightGetting = new WeightGetting(1);
        private int currentBobinNumber;
        private Shipment shp;

        public Pallet()
            : base()
            {
            ValueOfObjectPropertyChanged += new ValueOfObjectPropertyChangedDelegate(Pallet_ValueOfObjectPropertyChanged);
            TableRowDeleted += new TableRowDeletedDelegate(Pallet_TableRowDeleted);
            weightGetting.OnWeightAccepted += new WeightAcceptedDelegate(weightGetting_OnWeightAccepted);
            PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Pallet_PropertyChanged);
            AfterWriting += new AfterWritingDelegate(Pallet_AfterWriting);
            }

        void Pallet_AfterWriting(DatabaseObject item)
            {
            if ( !shp.Pallets.IsContain(this.Id, "Pallet") )
                {
                DataRow row = shp.Pallets.GetNewRow(shp);
                ItemFormTuner.SetRowValue(this.Id, row, shp.Pallet, shp);
                row.AddRowToTable(shp);
                shp.Write();
                }
            }

        protected override void InitItemBeforeShowing()
            {
            shp = ( Shipment ) new Shipment().ReadByNumber(Shipment);
            }

        void Pallet_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
            if ( e.PropertyName == "Shipment" )
                {
                shp = ( Shipment ) new Shipment().ReadByNumber(Shipment);
                if ( shp != null )
                    {
                    Tex = shp.Tex;
                        Query query = DB.NewQuery("");
                        query.AddInputParameter("Shipment", Shipment);                    
                    }
                }
            }

        void weightGetting_OnWeightAccepted(double value)
            {
            
            }

        void Pallet_TableRowDeleted(DataTable dataTable, DataRow currentRow)
            {
            nextNumbers.Add(( int ) currentRow[BobbinNumber]);
            }

        void Pallet_ValueOfObjectPropertyChanged(string propertyName)
            {
            if ( propertyName == "Tex" )
                {
                this.TexImage = Tex.TexImage;
                }
            }

        public void StartNewPallet()
            {
            if ( shp == null )
                {
                shp = new Shipment();
                shp.Tex = Tex;
                shp.Number = Shipment;
                shp.Write();
                }
            else if ( shp.Tex.Id != Tex.Id )
                {
                Tex = shp.Tex;
                }

            TotalShipmentWeight = shp.TotalShipmentWeight;
            TotalPalletWeight = 0;
            ( from DataRow x in Bobbins.Rows select ( double ) x[Weight] ).ToList<double>().ForEach(w => TotalPalletWeight += w);
            currentBobinNumber = shp.LastBobbinNumber;

            if ( Write() == WritingResult.Success )
                {
                weightGetting.Start();
                }
            }

        public void EndPacking()
            {
            weightGetting.Stop();
            }

        public void WeightGetting(double weight)
            {
            if ( weightGetting.Started )
                {
                CurrentWeight = weight;
                DataRow row = Bobbins.GetNewRow(this);

                if ( nextNumbers.Count > 0 )
                    {
                    row[BobbinNumber] = nextNumbers.Min;
                    nextNumbers.Remove(nextNumbers.Min);
                    }
                else
                    {
                    currentBobinNumber++;
                    row[BobbinNumber] = currentBobinNumber;
                    }
                row[Weight] = weight;
                ItemFormTuner.SetRowValue(CurrentShift, row, Shift, this);
                row.AddRowToTable(this);

                #region Old code
                //if ( deleted )
                //    {
                //    #region Если бобина была удалена
                //    BB.Weight = weight;
                //    BB.Date = DateTime.Now;
                //    BB.Smena = CBSmena.Text;
                //    BB.Part = PP;
                //    BB.Write();

                //    BBFromBD = new Babin();
                //    BBFromBD.Read(( long ) BB.Id);
                //    PL.O9pallet.Rows[babinNumber - 1]["Weight"] = BBFromBD.Weight;
                //    PL.O9pallet.Rows[babinNumber - 1]["Smena"] = BBFromBD.Smena;

                //    Documents.Jornal J = new Documents.Jornal();
                //    J.Date = DateTime.Now;
                //    J.TDescription = "Бобина №" + babinNumber.ToString() + " снова взвешена";
                //    J.SpecNum = PL.Number.ToString();
                //    J.Event = "Перевзвешивание";
                //    J.DCurUser = HugeWMS.Program.CurrentUser;
                //    J.Write();
                //    #endregion
                //    }
                //else
                //    {
                //    #region создание документа бобины, добавление данных о бобине в табличную часть
                //    babinNumber = CalculateBobinCountInPallet() + 1;
                //    LBCurrentBabin.Text = babinNumber.ToString();
                //    BB = new Babin();
                //    BB.BabinNumber = CalculateBobinCount() + 1;
                //    BB.Weight = weight;
                //    BB.pallet = PL;
                //    BB.Part = PP;
                //    BB.Smena = CBSmena.Text;
                //    BB.Date = DateTime.Now;
                //    BB.Write();

                //    BBFromBD = new Babin();
                //    BBFromBD.Read(( long ) BB.Id);
                //    DataRow row;
                //    row = PL.O9pallet.NewRow();
                //    row["LineNumber"] = babinNumber;
                //    row["Babin"] = BBFromBD.Id;
                //    row["IdDoc"] = PL.Id;
                //    row["BabinNumber"] = BBFromBD.BabinNumber;
                //    row["Weight"] = BBFromBD.Weight;
                //    row["Smena"] = BBFromBD.Smena;
                //    PL.O9pallet.Rows.Add(row);
                //    #endregion
                //    }
                #endregion

                //if ( ( complectation == 0 ) || ( complectation == 1 ) )
                //    {
                //    #region обычная упаковка или с колес - отображаем/печатаем этикетку
                //    BBFromBD = new Babin();
                //    BBFromBD.Read(( long ) BB.Id);
                //    PFO = new Labels.OneLabelPF();
                //    if ( checkBox1.Checked )
                //        {
                //        int length;
                //        length = ( int ) ( ( ( PackType ) PackType.Tag ).weight * 1000 / Convert.ToInt32(PP.Teks) );
                //        PFO.Fill(this.PBTeks.Image, length, BBFromBD, PLFromBD);
                //        }
                //    else
                //        PFO.Fill(this.PBTeks.Image, BB, PL);
                //    if ( HugeWMS.Program.IsDebugMode )
                //        {
                //        if ( checkEdit1.Checked ) PFO.ShowPreview();
                //        }
                //    else
                //        if ( checkEdit1.Checked ) PFO.Print();
                //    #endregion
                //    }
                //else
                //    {
                //    #region если групповая упаковка - печатаем групповую этикетку
                //    BBFromBD = new Babin();
                //    BBFromBD.Read(( long ) BB.Id);
                //    PFO = new Labels.OneLabelPF();
                //    if ( checkBox1.Checked )
                //        {
                //        int length;
                //        length = ( int ) ( ( ( PackType ) PackType.Tag ).weight * 1000 / Convert.ToInt32(PP.Teks) );
                //        PFO.Fill(this.PBTeks.Image, length, BBFromBD, PLFromBD, babinPerBag);
                //        }
                //    else
                //        PFO.Fill(this.PBTeks.Image, BB, PL, babinPerBag);
                //    if ( HugeWMS.Program.IsDebugMode )
                //        {
                //        if ( checkEdit1.Checked ) PFO.ShowPreview();
                //        }
                //    else
                //        if ( checkEdit1.Checked ) PFO.Print();
                //    #endregion
                //    }

                if ( deleted )
                    {
                    babinNumber = lastbabin;
                    deleted = false;
                    barButtonItem5.Enabled = true;
                    barButtonItem3.Enabled = true;
                    }
                totalweight = CalculateTotalWeight();
                WritePallet(false);
                if ( babinNumber == Convert.ToInt32(CBCounter.Text) )
                    EndShipping();
                TBWeight.Focus();
                TBWeight.Select(0, TBWeight.Text.Length);
                }
            }
        }
    }
