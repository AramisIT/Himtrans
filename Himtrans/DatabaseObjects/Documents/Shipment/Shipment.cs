using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseObjects;
using Aramis.Attributes;
using Catalogs;
using System.Drawing;
using Aramis.Enums;
using System.Data;
using Aramis.DatabaseConnector;
using Aramis.UI.WinFormsDevXpress;

namespace Documents
    {
    [Document(Description = "Партия", GUID = "009CD186-D21A-4AF3-BD81-A4B7E8D1B38B", ShowDateInForm = false, NumberIsReadonly = true)]
    public class Shipment:DocumentTable
        {
        private bool needWriteToJornal = false;

        [DataField(Description = "Текс", ShowInList = true, NotEmpty = true, ReadOnly = true)]
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

        [DataField(Description = "Вес партии", StorageType = StorageTypes.Virtual, Formula = "[dbo].GetShipmentTotalWeight(Number)", DecimalPointsNumber = 3)]
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

        [DataField(Description = "Номер последней бобины в парти", StorageType = StorageTypes.Virtual, Formula = "[dbo].GetLastShipmentBobinNumber(Number)")]
        public int LastBobbinNumber
            {
            get { return z_LastBobbinNumber; }
            set
                {
                if ( z_LastBobbinNumber == value )
                    {
                    return;
                    }
                z_LastBobbinNumber = value;
                NotifyPropertyChanged("LastBobbinNumber");
                }
            }
        private int z_LastBobbinNumber;

        [Table(Columns = "Pallet")]
        [DataField(Description = "Палеты", StorageType = StorageTypes.Local, ReadOnly = true)]
        public DataTable Pallets
            {
            get
                {
                return GetSubtable("Pallets");
                }
            }

        [SubTableField(Description = "Палета", PropertyType = typeof(Pallet), AllowOpenItem = true, ReadOnly = true)]
        public DataColumn Pallet
            {
            get;
            set;
            }

        public Shipment()
            : base()
            {
            OnVirtualColumnsRecreate += new Aramis.SystemConfigurations.VirtualColumnsRecreateDelegate(Shipment_OnVirtualColumnsRecreate);
            BeforeWriting += new BeforeWritingDelegate(Shipment_BeforeWriting);
            AfterWriting += new AfterWritingDelegate(Shipment_AfterWriting);
            }

        void Shipment_AfterWriting(DatabaseObject item)
            {
            if ( needWriteToJornal )
                {
                Jornal J = new Jornal();
                J.Date = CreationDate;
                J.Event = Events.ShipmentOpened;
                J.Description = String.Format("Открыта партия №{0}", Number);
                J.Write();
                }
            }

        void Shipment_BeforeWriting(DatabaseObject item, ref bool cancel)
            {
            if ( IsNew )
                {
                needWriteToJornal = true;
                }
            }

        List<string> Shipment_OnVirtualColumnsRecreate()
            {
            List<string> funcText = new List<string>(){@"create function [dbo].[GetShipmentTotalWeight] (@Number int)
returns real
begin
declare @result real
 select @result = (select Round(isnull(sum(TotalPalletWeight), 0), 3) from pallet where Shipment = @Number and MarkForDeleting = 0)
 return @result
end"
,@"create function [dbo].[GetLastShipmentBobinNumber] (@Number int)
returns int
begin
declare @result int
 select @result = (select Max(BobbinNumber) from SubPalletBobbins b
join Pallet p
on b.IdDoc = p.Id
where p.Shipment = @Number and p.MarkForDeleting = 0)
 return @result
end"};
            return Aramis.SystemConfigurations.SystemCheckers.CheckSPExistings.RewriteByList(funcText, false);
            }

        protected override void InitItemBeforeShowing()
            {
            TexImage = Tex.TexImage;
            Pallets.Rows.Clear();
            Query query = DB.NewQuery("select Id from pallet where Shipment = @Shipment and markfordeleting = 0");
            query.AddInputParameter("Shipment", Number);
            QueryResult result = query.Select();
            while ( result.Next() )
                {
                DataRow row = Pallets.AddSubtableRow();
                row[Pallet] = result["Id"];
                }
            }
        }
    }
